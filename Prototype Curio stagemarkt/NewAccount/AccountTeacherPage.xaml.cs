using Microsoft.EntityFrameworkCore;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Main;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountTeacherPage : Page
    {
        //private int? _selectedStudentId;
        public ObservableCollection<WorkHour> ApprovedWorkHours { get; set; } = new ObservableCollection<WorkHour>();
        public ObservableCollection<WorkHour> UnapprovedWorkHours { get; set; } = new ObservableCollection<WorkHour>();
        public ObservableCollection<WorkHour> InreviewdWorkHours { get; set; } = new ObservableCollection<WorkHour>();



        public AccountTeacherPage()
        {
            InitializeComponent();
            LoadWorkHours();
        }

        private void LoadWorkHours()
        {
            using var db = new AppDbContext();

            var workHours = db.WorkHours
                .Include(w => w.Student)
                .ToList();

            ApprovedWorkHours.Clear();
            UnapprovedWorkHours.Clear();
            InreviewdWorkHours.Clear();

            foreach (var workHour in workHours)
            {
                if (workHour.Status == WorkHoursStatus.Approved)
                {
                    ApprovedWorkHours.Add(workHour);
                }
                else if (workHour.Status == WorkHoursStatus.InReview)
                {
                    InreviewdWorkHours.Add(workHour);
                }
                else
                {
                    UnapprovedWorkHours.Add(workHour);
                }
            }
        }

        private void LogoButton_Click(
            object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            Frame.Navigate(typeof(WelcomePage));
        }

        private void HourcardCalendar_CalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {
            if (args.Item is CalendarViewDayItem calendarItem)
            {
                var calendarItemDate = args.Item.Date.Date;

                using var db = new AppDbContext();
                var studentWorkHours = db.WorkHours
                    .Include(w => w.Student)
                    .ThenInclude(s => s.InternschipTeacher)
                    .Where(m => m.Date.Date == calendarItemDate)
                    .Where(m => m.Status != WorkHoursStatus.Approved)
                    .ToList();

                calendarItem.DataContext = studentWorkHours;

                int studentCount = studentWorkHours.Count;

                var dayDataContext = new
                {
                    StudentCount = studentCount,
                    WorkHours = studentWorkHours
                };

                calendarItem.DataContext = dayDataContext;

                args.Item.IsBlackout = !studentWorkHours.Any();
            }
        }


        private async void TeacherListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is WorkHour clickedWorkHour)
            {
                // Prevent editing if the work hour is approved
                if (clickedWorkHour.Status == WorkHoursStatus.Approved)
                {
                    await approvedDialog.ShowAsync();
                    return; // Exit the method to prevent further actions
                }

                workHourDialog.DataContext = clickedWorkHour;
                await workHourDialog.ShowAsync();
            }
        }

        private async void WorkHourDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            await UpdateWorkHourStatus(WorkHoursStatus.Approved);
        }

        private async void WorkHourDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            await UpdateWorkHourStatus(WorkHoursStatus.Rejected);
        }

        private async Task UpdateWorkHourStatus(WorkHoursStatus status)
        {
            if (workHourDialog.DataContext is WorkHour workHour)
            {
                using var db = new AppDbContext();
                var existingWorkHour = await db.WorkHours.FindAsync(workHour.Id);

                if (existingWorkHour != null)
                {
                    var dialogRoot = workHourDialog.ContentTemplateRoot as FrameworkElement;
                    var reasonTextBox = dialogRoot?.FindName("reasonTextBox") as TextBox;

                    existingWorkHour.Status = status;
                    existingWorkHour.Reason = reasonTextBox?.Text;

                    db.WorkHours.Update(existingWorkHour);
                    await db.SaveChangesAsync();
                    this.Frame.Navigate(typeof(AccountTeacherPage));
                }
            }
        }

        private async void ApprovedWorkHours_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var groupedWorkHours = ApprovedWorkHours
                .Where(wh => wh.Student != null)
                .GroupBy(wh => new { wh.Student.Name, wh.Status })
                .Select(g => new
                {
                    StudentName = g.Key.Name,
                    WorkHours = g.ToList(),
                    WorkHoursStatus = g.Key.Status // Voeg de status toe aan de selectie
                })
                .ToList();

            workHoursListView.ItemsSource = groupedWorkHours; // Bind to grouped work hours
            await showWorkHoursDetailDialog.ShowAsync(); // Show the dialog
        }


        private async void UnapprovedWorkHours_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var groupedWorkHours = UnapprovedWorkHours
               .Where(wh => wh.Student != null)
               .GroupBy(wh => wh.Student.Name)
               .Select(g => new
               {
                   StudentName = g.Key,
                   WorkHours = g.ToList()
               })
               .ToList();

            workHoursListView.ItemsSource = groupedWorkHours; // Bind to grouped work hours
            await showWorkHoursDetailDialog.ShowAsync(); // Show the dialog
        }

        private async void InreviewdWorkHours_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var groupedWorkHours = InreviewdWorkHours
               .Where(wh => wh.Student != null)
               .GroupBy(wh => wh.Student.Name)
               .Select(g => new
               {
                   StudentName = g.Key,
                   WorkHours = g.ToList()
               })
               .ToList();

            workHoursListView.ItemsSource = groupedWorkHours; // Bind to grouped work hours
            await showWorkHoursDetailDialog.ShowAsync(); // Show the dialog
        }

        private async Task ShowWorkHourDetails(ObservableCollection<WorkHour> workHours)
        {
            workHoursListView.ItemsSource = workHours; // Bind the ListView to the appropriate collection
            await showWorkHoursDetailDialog.ShowAsync(); // Show the dialog
        }

    }
}
