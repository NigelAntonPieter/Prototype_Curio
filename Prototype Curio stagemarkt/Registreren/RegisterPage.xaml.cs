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
using Prototype_Curio_stagemarkt.Data.Model;
using Prototype_Curio_stagemarkt.Data.Models;



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
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadCourses();
            LoadLearningPaths();
            LoadLevelPaths();
        }

        private void LoadCourses()
        {
            using (var db = new AppDbContext())
            {
                var courses = db.Courses.ToList();
                studentCourseCombobox.ItemsSource = courses;
                companyCourseCombobox.ItemsSource = courses;
                studentCourseCombobox.DisplayMemberPath = companyCourseCombobox.DisplayMemberPath = "Name";
                studentCourseCombobox.SelectedValuePath = companyCourseCombobox.SelectedValuePath = "Id";
            }
        }

        private void LoadLearningPaths()
        {
            using (var db = new AppDbContext())
            {
                var learningPaths = db.LearningPaths.ToList();
                companyLearningPathComboBox.ItemsSource = learningPaths;
                companyLearningPathComboBox.DisplayMemberPath = "Name";
                companyLearningPathComboBox.SelectedValuePath = "Id";
            }
        }

        private void LoadLevelPaths()
        {
            using (var db = new AppDbContext())
            {
                var levels = db.Levels.ToList();
                companyLevelComboBox.ItemsSource = levels;
                companyLevelComboBox.DisplayMemberPath = "GradeLevel";
                companyLevelComboBox.SelectedValuePath = "Id";
            }
        }


        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WelcomePage));
        }

        private void RegisterStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateStudentInputs())
            {
                RegisterStudent();
            }
        }

        private void RegisterCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateCompanyInputs(out var level))
            {
                RegisterCompany();
            }
        }

        private async void fileButton_Click(object sender, RoutedEventArgs e)
        {
            await SelectAndCopyFileAsync();
        }

        // Register methods

        private void RegisterStudent()
        {
            using (var db = new AppDbContext())
            {
                var selectedCourse = studentCourseCombobox.SelectedItem as Course;
                var internshipTeacher = db.InternschipTeachers.FirstOrDefault();

                if (internshipTeacher == null) return;

                var newStudent = new Student
                {
                    Name = studentUsernameTextbox.Text,
                    Password = SecureHasher.Hash(studentPasswordBox.Password),
                    EmailAddress = studentEmailTextbox.Text,
                    Specialization = selectedCourse?.Name,
                    InternshipTeacherId = internshipTeacher.Id
                };

                db.Students.Add(newStudent);
                db.SaveChanges();

                var newUser = new User
                {
                    IsCompany = false,
                    StudentId = newStudent.Id,
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                User.LoggedInUser = newUser;
                Frame.Navigate(typeof(MainCurioPage));
            }
        }

        private void RegisterCompany()
        {
            using (var db = new AppDbContext())
            {
                var selectedCourse = companyCourseCombobox.SelectedItem as Course;
                var selectedLearningPath = (int)companyLearningPathComboBox.SelectedValue;
                var selectedLevel = (int)companyLevelComboBox.SelectedValue;

                var newCompany = new Company
                {
                    Name = companyNameTextbox.Text,
                    Phone = companyPhoneTextbox.Text,
                    EmailAddress = companyEmailTextbox.Text,
                    Street = companyStreetTextbox.Text,
                    City = companyCityTextbox.Text,
                    Description = companyDescriptionTextbox.Text,
                    LevelId = selectedLevel,
                    LearningPathId = selectedLearningPath,
                    Specialization = selectedCourse?.Name,
                    ImagePath = copiedFile?.Path,
                    Password = SecureHasher.Hash(companyPasswordBox.Password),
                };

                db.Companies.Add(newCompany);
                db.SaveChanges();

                var newUser = new User
                {
                    IsCompany = true,
                    CompanyId = newCompany.Id,
                    Company = newCompany
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                User.LoggedInUser = newUser;
                Frame.Navigate(typeof(AccountCompanyPage));
            }
        }

        // File picker

        private async Task SelectAndCopyFileAsync()
        {
            var filePicker = new FileOpenPicker
            {
                FileTypeFilter = { ".jpg", ".jpeg", ".png", ".gif" }
            };

            var windowHandle = WindowNative.GetWindowHandle(App.m_window);
            InitializeWithWindow.Initialize(filePicker, windowHandle);

            var file = await filePicker.PickSingleFileAsync();
            if (file != null)
            {
                var localFolder = ApplicationData.Current.LocalFolder;
                var fileExtension = file.FileType;
                var renamedFileName = $"{DateTime.Now.ToFileTime()}{fileExtension}";

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
                ShowErrorDialog();
                return false;
            }

            return true;
        }


        private bool ValidateCompanyInputs(out int level)
        {
            level = 0;

            if (string.IsNullOrWhiteSpace(companyNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyPhoneTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyEmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyStreetTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyCityTextbox.Text) ||
                string.IsNullOrWhiteSpace(companyDescriptionTextbox.Text) ||
                companyLevelComboBox.SelectedItem == null ||
                companyLearningPathComboBox.SelectedItem == null ||
                companyCourseCombobox.SelectedItem == null ||
                copiedFile == null)
            {
                ShowErrorDialog();
                return false;
            }

            return true;
        }


        private async void ShowErrorDialog()
        {
            await ErrorDialog.ShowAsync();
        }
    }
}
