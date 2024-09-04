using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Main;
using Prototype_Curio_stagemarkt.Utility;
using Prototype_Curio_stagemarkt.Login;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;
using WinRT.Interop;



// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Registreren
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        private StorageFile copiedFile;

        public RegisterPage()
        {
            this.InitializeComponent();

            using (var context = new AppDbContext())
            {
                var courses = context.Courses.ToList();
                studentCourseCombobox.ItemsSource = courses;
                studentCourseCombobox.DisplayMemberPath = "Name";
                studentCourseCombobox.SelectedValuePath = "Id";
                companyCourseCombobox.ItemsSource = courses;
                companyCourseCombobox.DisplayMemberPath = "Name";
                companyCourseCombobox.SelectedValuePath = "Id";
            }
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }

        private void RegisterStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateStudentInputs())
            {
                using (var db = new AppDbContext())
                {
                    var selectedCourse = studentCourseCombobox.SelectedItem as Course;

                    var newStudent = new Student
                    {
                        Name = studentUsernameTextbox.Text,
                        Password = SecureHasher.Hash(studentPasswordBox.Password),
                        EmailAdress = studentEmailTextbox.Text,
                        Specialization = selectedCourse?.Name,

                    };

                    db.Students.Add(newStudent);
                    db.SaveChanges();

                    // Maak een User-object aan voor de student
                    var newUser = new User
                    {
                        IsCompany = false,
                        StudentId = newStudent.Id,
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    User.LoggedInUser = newUser;
                    this.Frame.Navigate(typeof(MainCurioPage));
                }
            }
        }

        private void RegisterCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateCompanyInputs(out int level))
            {
                using (var db = new AppDbContext())
                {
                    var selectedCourse = companyCourseCombobox.SelectedItem as Course;

                    var newCompany = new Company
                    {
                        Name = companyNameTextbox.Text,
                        Phone = companyPhoneTextbox.Text,
                        EmailAddress = companyEmailTextbox.Text,
                        Street = companyStreetTextbox.Text,
                        City = companyCityTextbox.Text,
                        Description = companyDescriptionTextbox.Text,
                        Level = level,
                        LearningPath = companyLearningPathTextbox.Text,
                        Specialization = selectedCourse?.Name,
                        ImagePath = copiedFile?.Path,
                        Password = SecureHasher.Hash(companyPasswordBox.Password),
                    };

                    db.Companies.Add(newCompany);
                    db.SaveChanges();

                    // Maak een User-object aan voor het bedrijf
                    var newUser = new User
                    {
                        IsCompany = true,
                        CompanyId = newCompany.Id,
                        Company = newCompany
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    User.LoggedInUser = newUser;
                    this.Frame.Navigate(typeof(AccountCompanyPage));
                }
            }
        }

        private async void fileButton_Click(object sender, RoutedEventArgs e)
        {
            await SelectAndCopyFileAsync();
        }

        private async Task SelectAndCopyFileAsync()
        {
            var fileopenPicker = new FileOpenPicker
            {
                FileTypeFilter = { ".jpg", ".jpeg", ".png", ".gif" }
            };

            nint windowHandle = WindowNative.GetWindowHandle(App.m_window);
            InitializeWithWindow.Initialize(fileopenPicker, windowHandle);

            var file = await fileopenPicker.PickSingleFileAsync();

            if (file != null)
            {
                var localFolder = ApplicationData.Current.LocalFolder;

                var fileExtension = file.FileType;

                var currentTime = DateTime.Now;
                var renamedFileName = $"{currentTime.ToFileTime()}{fileExtension}";

                copiedFile = await file.CopyAsync(localFolder, renamedFileName);
            }
        }

        // Validation methods

        private bool ValidateStudentInputs()
        {
            if (string.IsNullOrWhiteSpace(studentUsernameTextbox.Text) ||
                string.IsNullOrWhiteSpace(studentPasswordBox.Password) ||
                studentCourseCombobox.SelectedItem == null)
            {
                ShowErrorMessage("Please fill in all fields for student registration.");
                return false;
            }
            return true;
        }

        private bool ValidateCompanyInputs(out int level)
        {
            level = 0; // Default value
            if (string.IsNullOrWhiteSpace(companyNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyPhoneTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyEmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyStreetTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyCityTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyDescriptionTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyLevelTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyLearningPathTextbox.Text) ||
                companyCourseCombobox.SelectedItem == null ||
                copiedFile == null)
            {
                ShowErrorMessage("Please fill in all fields for company registration.");
                return false;
            }
            if (!int.TryParse(companyLevelTextbox.Text, out level))
            {
                ShowErrorMessage("The Level field must be a valid number.");
                return false;
            }
            return true;
        }

        private void ShowErrorMessage(string message)
        {
            var dialog = new ContentDialog
            {
                Title = "Error",
                Content = message,
                CloseButtonText = "OK"
            };

            dialog.XamlRoot = this.Content.XamlRoot; // Set the XamlRoot of the dialog to match the page
            _ = dialog.ShowAsync();
        }
    }
}
