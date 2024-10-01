using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.EntityFrameworkCore;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.NewAccount
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HourCardPage : Page
    {
        private Dictionary<DateTime, List<double>> workHoursByDate;
        private const int TotalWorkHoursRequired = 576;

        public HourCardPage()
        {
            this.InitializeComponent();
            LoadStudentWorkHours();

            using var db = new AppDbContext();
            workHoursByDate = new Dictionary<DateTime, List<double>>();
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }

        private void LoadStudentWorkHours()
        {
            using var db = new AppDbContext();
            int studentId = User.LoggedInUser.StudentId ?? 0;

            // Haal de student op uit de database
            var student = db.Students.Include(s => s.workHours).FirstOrDefault(s => s.Id == studentId);

            if (student != null)
            {
                // Tel de goedgekeurde werkuren op
                double approvedWorkHours = student.workHours
                    .Where(wh => wh.Status == WorkHoursStatus.Approved)
                    .Sum(wh => wh.HoursWorked);

                int remainingHours = TotalWorkHoursRequired - (int)approvedWorkHours;

                // Update de header of een ander element op de pagina
                myWorkHours.Text = $"Je hebt nog {remainingHours} uur te lopen.";
            }
        }


        private void HourcardCalendar_CalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {
            DateTime today = DateTime.Now.Date;
            DateTime stageStartDate = new DateTime(2024, 8, 19);

            if (args.Item.Date < stageStartDate || args.Item.Date > today)
            {
                args.Item.IsBlackout = true;
                args.Item.IsTabStop = false;
                args.Item.Background = new SolidColorBrush(Colors.Transparent);
                return;
            }

            args.Item.IsBlackout = false;
            args.Item.IsTabStop = true;

            DateTime selectedDate = args.Item.Date.Date;

            using (var db = new AppDbContext())
            {
                var workHours = db.WorkHours
                    .Where(wh => wh.Date == selectedDate && wh.StudentId == User.LoggedInUser.StudentId)
                    .ToList();

                if (workHours.Any())
                {
                    var firstWorkHour = workHours.First();
                    args.Item.Background = firstWorkHour.Status switch
                    {
                        WorkHoursStatus.Approved => new SolidColorBrush(Colors.Green),
                        WorkHoursStatus.Unapproved => new SolidColorBrush(Colors.Red),
                        _ => new SolidColorBrush(Colors.Orange),
                    };

                    args.Item.DataContext = workHours;
                }
                else
                {
                    args.Item.Background = new SolidColorBrush(Colors.Transparent);
                    args.Item.DataContext = null;
                }
            }
        }


        private void WorkHoursDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (int.TryParse(HoursTextBox.Text, out int hoursWorked) && hoursWorked >= 0)
            {
                DateTime selectedDate = HourcardCalendar.SelectedDates[0].Date;

                int studentId = User.LoggedInUser.StudentId ?? 0;

                using (var db = new AppDbContext())
                {
                    // Zoek naar bestaande werkuren voor de geselecteerde datum
                    var workHour = db.WorkHours.FirstOrDefault(wh => wh.Date == selectedDate && wh.StudentId == studentId);

                    if (workHour != null)
                    {
                        // Update bestaande werkuren
                        workHour.HoursWorked = hoursWorked;

                        if (workHour.Status == WorkHoursStatus.Unapproved)
                        {
                            workHour.Status = WorkHoursStatus.InReview;
                            workHour.Reason = string.Empty;
                        }
                    }
                    else
                    {
                        // Voeg nieuwe werkuren toe
                        workHour = new WorkHour
                        {
                            StudentId = studentId,
                            Date = selectedDate.Date,
                            HoursWorked = hoursWorked,
                            Status = WorkHoursStatus.InReview,
                        };
                        db.WorkHours.Add(workHour);
                    }
                    db.SaveChanges();
                }
                this.Frame.Navigate(typeof(HourCardPage));
            }
            else
            {
                errorTextblock.Text = "Voer wel een nummer in.";
                args.Cancel = true;
            }
        }




        private async void HourcardCalendar_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            if (args.AddedDates.Count > 0)
            {
                // Controleer of er geselecteerde datums zijn
                if (HourcardCalendar.SelectedDates.Count > 0)
                {
                    DateTime selectedDate = HourcardCalendar.SelectedDates[0].Date;

                    // Controleer of de geselecteerde datum niet in de toekomst ligt
                    if (selectedDate <= DateTime.Today)
                    {
                        using (var db = new AppDbContext())
                        {
                            var workHour = db.WorkHours.FirstOrDefault(wh => wh.Date == selectedDate && wh.StudentId == User.LoggedInUser.StudentId);

                            if (workHour != null)
                            {
                                HoursTextBox.Text = workHour.HoursWorked.ToString();
                                ReasonTextBlock.Text = workHour.Reason;
                                ReasonTextBlock.Visibility = Visibility.Visible;

                                if (workHour.Status == WorkHoursStatus.Approved)
                                {
                                    HoursTextBox.IsReadOnly = true;
                                }
                                else
                                {
                                    HoursTextBox.IsReadOnly = false;
                                }
                            }
                            else
                            {
                                HoursTextBox.Text = string.Empty;
                                ReasonTextBlock.Text = string.Empty;
                                ReasonTextBlock.Visibility = Visibility.Collapsed;
                            }
                        }

                        await WorkHoursDialog.ShowAsync();
                    }
                    else
                    {
                        // Geef een foutmelding als de geselecteerde datum in de toekomst ligt
                        errorTextblock.Text = "Je kunt geen uren invullen voor een toekomstige datum.";
                    }
                }
                else
                {
                    // Geen datum geselecteerd, geef een foutmelding of doe iets anders
                    errorTextblock.Text = "Geen datum geselecteerd.";
                }
            }
        }



        private void WorkHoursDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            this.Frame.Navigate(typeof(HourCardPage));
        }
    }
}
