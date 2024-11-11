using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data;
using SharedModel;
using Prototype_Curio_stagemarkt.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Prototype_Curio_stagemarkt.NewAccount
{
    public sealed partial class HourCardPage : Page
    {
        private Dictionary<DateTime, List<double>> workHoursByDate;
        private const int TotalWorkHoursRequired = 576;

        public HourCardPage()
        {
            this.InitializeComponent();
            LoadStudentWorkHours();
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
            var student = db.Students.Include(s => s.workHours).FirstOrDefault(s => s.Id == studentId);

            if (student != null)
            {
                double approvedWorkHours = student.workHours
                    .Where(wh => wh.Status == WorkHoursStatus.Approved)
                    .Sum(wh => wh.HoursWorked);

                int remainingHours = TotalWorkHoursRequired - (int)approvedWorkHours;
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
                    var workHour = db.WorkHours.FirstOrDefault(wh => wh.Date == selectedDate && wh.StudentId == studentId);

                    if (workHour != null)
                    {
                        workHour.HoursWorked = hoursWorked;

                        if (workHour.Status == WorkHoursStatus.Unapproved)
                        {
                            workHour.Status = WorkHoursStatus.InReview;
                            workHour.Reason = string.Empty;
                        }
                    }
                    else
                    {
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
                if (HourcardCalendar.SelectedDates.Count > 0)
                {
                    DateTime selectedDate = HourcardCalendar.SelectedDates[0].Date;

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

                                HoursTextBox.IsReadOnly = workHour.Status == WorkHoursStatus.Approved;
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
                        errorTextblock.Text = "Je kunt geen uren invullen voor een toekomstige datum.";
                    }
                }
                else
                {
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
