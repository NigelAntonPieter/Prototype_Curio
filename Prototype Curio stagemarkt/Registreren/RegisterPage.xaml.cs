using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;
using Prototype_Curio_stagemarkt.Data;
using SharedModel.Model;
using SharedModel.Data;
using Prototype_Curio_stagemarkt.Main;
using Prototype_Curio_stagemarkt.Utility;
using Prototype_Curio_stagemarkt.Login;

namespace Prototype_Curio_stagemarkt.Registreren
{
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
            using var db = new CurioContext();
            var courses = db.Courses.ToList();
            studentCourseCombobox.ItemsSource = courses;
            companyCourseCombobox.ItemsSource = courses;
            studentCourseCombobox.DisplayMemberPath = companyCourseCombobox.DisplayMemberPath = "Name";
            studentCourseCombobox.SelectedValuePath = companyCourseCombobox.SelectedValuePath = "Id";
        }

        private void LoadLearningPaths()
        {
            using var db = new CurioContext();
            var learningPaths = db.LearningPaths.ToList();
            companyLearningPathComboBox.ItemsSource = learningPaths;
            companyLearningPathComboBox.DisplayMemberPath = "Name";
            companyLearningPathComboBox.SelectedValuePath = "Id";
        }

        private void LoadLevelPaths()
        {
            using var db = new CurioContext();
            var levels = db.Levels.ToList();
            companyLevelComboBox.ItemsSource = levels;
            companyLevelComboBox.DisplayMemberPath = "GradeLevel";
            companyLevelComboBox.SelectedValuePath = "Id";
        }

        private async void RegisterStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateStudentInputs())
            {
                await RegisterStudent();
            }
        }

        private async void RegisterCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateCompanyInputs())
            {
                await RegisterCompany();
            }
        }

        private async Task RegisterStudent()
        {
            using var db = new CurioContext();

            if (db.Students.Any(s => s.EmailAddress == studentEmailTextbox.Text))
            {
                await existingDialog.ShowAsync();
                return;
            }

            var selectedCourse = studentCourseCombobox.SelectedItem as Course;
            var internshipTeacher = db.InternschipTeachers.FirstOrDefault();
            if (internshipTeacher == null) return;

            var newStudent = new Student
            {
                Name = studentUsernameTextbox.Text,
                Password = SecureHasher.Hash(studentPasswordBox.Password),
                EmailAddress = studentEmailTextbox.Text,
                Specialization = selectedCourse?.Name,
                InternshipTeacherId = internshipTeacher.Id,
                ImagePath = copiedFile?.Path
            };

            db.Students.Add(newStudent);
            db.SaveChanges();

            var newUser = new User { IsCompany = false, StudentId = newStudent.Id };
            db.Users.Add(newUser);
            db.SaveChanges();

            User.LoggedInUser = newUser;
            Frame.Navigate(typeof(MainCurioPage));
        }

        private async Task RegisterCompany()
        {
            using var db = new CurioContext();

            if (db.Companies.Any(c => c.EmailAddress == companyEmailTextbox.Text))
            {
                await existingDialog.ShowAsync();
                return;
            }

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
                Password = SecureHasher.Hash(companyPasswordBox.Password)
            };

            db.Companies.Add(newCompany);
            db.SaveChanges();

            var newUser = new User { IsCompany = true, CompanyId = newCompany.Id };
            db.Users.Add(newUser);
            db.SaveChanges();

            User.LoggedInUser = newUser;
            Frame.Navigate(typeof(AccountCompanyPage));
        }

        private async Task SelectAndCopyFileAsync()
        {
            var filePicker = new FileOpenPicker { FileTypeFilter = { ".jpg", ".jpeg", ".png", ".gif" } };
            var windowHandle = WindowNative.GetWindowHandle(App.m_window);
            InitializeWithWindow.Initialize(filePicker, windowHandle);

            var file = await filePicker.PickSingleFileAsync();
            if (file != null)
            {
                var localFolder = ApplicationData.Current.LocalFolder;
                copiedFile = await file.CopyAsync(localFolder, $"{DateTime.Now.ToFileTime()}{file.FileType}");
            }
        }

        private bool ValidateStudentInputs()
        {
            if (!string.IsNullOrWhiteSpace(studentUsernameTextbox.Text) &&
                !string.IsNullOrWhiteSpace(studentPasswordBox.Password) &&
                studentCourseCombobox.SelectedItem != null)
            {
                return true;
            }

            ShowErrorDialog();
            return false;
        }

        private bool ValidateCompanyInputs()
        {
            if (!string.IsNullOrWhiteSpace(companyNameTextbox.Text) &&
                !string.IsNullOrWhiteSpace(companyPhoneTextbox.Text) &&
                !string.IsNullOrWhiteSpace(companyEmailTextbox.Text) &&
                !string.IsNullOrWhiteSpace(companyStreetTextbox.Text) &&
                !string.IsNullOrWhiteSpace(companyCityTextbox.Text) &&
                !string.IsNullOrWhiteSpace(companyDescriptionTextbox.Text) &&
                companyLevelComboBox.SelectedItem != null &&
                companyLearningPathComboBox.SelectedItem != null &&
                companyCourseCombobox.SelectedItem != null &&
                copiedFile != null)
            {
                return true;
            }

            ShowErrorDialog();
            return false;
        }

        private async void ShowErrorDialog()
        {
            await ErrorDialog.ShowAsync();
        }

        private async void fileButton_Click(object sender, RoutedEventArgs e) => await SelectAndCopyFileAsync();

        private void LogoButton_Click(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(WelcomePage));
    }
}
