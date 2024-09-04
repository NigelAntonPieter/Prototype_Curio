using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountCompanyPage : Page
    {
        private Company _company;
        public AccountCompanyPage()
        {
            this.InitializeComponent();
            //LoadUserData();
            //LoadCourses();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var company = e.Parameter as Company;
            if (company != null)
            {
                // Laad de gegevens van het bedrijf
                companyNameTextbox.Text = company.Name;
                companyEmailTextbox.Text = company.EmailAddress;
                companyPhoneTextbox.Text= company.Phone;
                companyStreetTextbox.Text = company.Street;
                companyCityTextbox.Text = company.City;
                companyDescriptionTextbox.Text = company.Description;
                companyLevelTextbox.Text = company.Level.ToString();
                companyLearningPathTextbox.Text = company.LearningPath;
                companyCourseCombobox.Text = company.Specialization;
                isPlaceOpen.IsChecked = company.IsOpen; 
            }
            //private void LoadUserData()
            //{
            //    var user = User.LoggedInUser;

            //    if (user != null)
            //    {
            //        companyNameTextbox.Text = user.Name;

            //        // Display a placeholder or leave the PasswordBox empty
            //        studentPasswordBox.Password = "********"; // or just leave it empty

            //        companyCourseCombobox.SelectedItem = companyCourseCombobox.Items
            //            .Cast<ComboBoxItem>()
            //            .FirstOrDefault(item => item.Content.ToString() == user.Course);
            //    }
            //}

            //private void LoadCourses()
            //{
            //    using var db = new AppDbContext();
            //    var courses = db.Courses.Select(c => c.Name).ToList();
            //    companyCourseCombobox.Items.Clear();
            //    foreach (var course in courses)
            //    {
            //        companyCourseCombobox.Items.Add(new ComboBoxItem { Content = course });
            //    }
        }
        private void registerNewAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }

        private void fileButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void registerCompanyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void isPlaceOpen_Unchecked(object sender, RoutedEventArgs e)
        {
            // Als de CheckBox is aangevinkt, stel IsOpen in op true
            if (_company != null)
            {
                _company.IsOpen = true;
            }
        }
        

        private void isPlaceOpen_Checked(object sender, RoutedEventArgs e)
        {
            if (_company != null)
            {
                _company.IsOpen = false;
            }
        }
    }
}
