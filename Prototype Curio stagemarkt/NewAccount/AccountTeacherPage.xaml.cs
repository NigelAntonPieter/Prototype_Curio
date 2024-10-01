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

        private int? _selectedStudentId;
        public AccountTeacherPage()
        {
            this.InitializeComponent();
        }


        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            this.Frame.Navigate(typeof(WelcomePage));
        }



        private void HourcardCalendar_CalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {
            if (args.Item is CalendarViewDayItem calendarItem)
            {
                using var db = new AppDbContext();
                var calendarItemDate = args.Item.Date.Date;

                var studentWorkHours = db.WorkHours
                .Include(w => w.Student)
                .ThenInclude(s => s.InternschipTeacher)
                .Where(m => m.Date.Date == calendarItemDate)
                .ToList();

                var allWorkHours = new List<WorkHour>();
                allWorkHours.AddRange(studentWorkHours);


                calendarItem.DataContext = allWorkHours;

                if (allWorkHours.Count() == 0)
                {
                    args.Item.IsBlackout = true;
                }
            }
        }

        private async void teacherListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is WorkHour clickedWorkHour)
            {
                workHourDialog.DataContext = clickedWorkHour;
                await workHourDialog.ShowAsync();
            }
        }

        private async void workHourDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (workHourDialog.DataContext is WorkHour workHour)
            {

                using var db = new AppDbContext();

                var existingWorkHour = db.WorkHours.FirstOrDefault(wh => wh.Id == workHour.Id);

                if (existingWorkHour != null)
                {
                    var dialogRoot = workHourDialog.ContentTemplateRoot as FrameworkElement;
                    var reasonTextBox = dialogRoot?.FindName("reasonTextBox") as TextBox;
                    existingWorkHour.Status = WorkHoursStatus.Approved;
                    existingWorkHour.Reason = reasonTextBox?.Text;

                    db.WorkHours.Update(existingWorkHour);
                    await db.SaveChangesAsync();
                }
            }
        }

        private async void workHourDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (workHourDialog.DataContext is WorkHour workHour)
            {
                using var db = new AppDbContext();

                var existingWorkHour = db.WorkHours.FirstOrDefault(wh => wh.Id == workHour.Id);

                if (existingWorkHour != null)
                {
                    var dialogRoot = workHourDialog.ContentTemplateRoot as FrameworkElement;
                    var reasonTextBox = dialogRoot?.FindName("reasonTextBox") as TextBox;

                    existingWorkHour.Status = WorkHoursStatus.Rejected;
                    existingWorkHour.Reason = reasonTextBox.Text;

                    db.WorkHours.Update(existingWorkHour);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
