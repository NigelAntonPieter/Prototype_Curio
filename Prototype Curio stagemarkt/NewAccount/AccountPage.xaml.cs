using Microsoft.EntityFrameworkCore;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Companywindow;
using Prototype_Curio_stagemarkt.Data;
using SharedModel;
using Prototype_Curio_stagemarkt.Main;
using Prototype_Curio_stagemarkt.NewAccount;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Linq;

namespace Prototype_Curio_stagemarkt.Login
{
    public sealed partial class AccountPage : Page
    {
        public AccountPage()
        {
            InitializeComponent();
            LoadCourses();
            LoadFavoriteCompanies();
            LoadCompaniesWithMessages();
            DataContext = User.LoggedInUser;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            PopulateStudentInfo();
        }

        private void PopulateStudentInfo()
        {
            var loggedInUser = User.LoggedInUser;
            if (loggedInUser?.Student != null)
            {
                var student = loggedInUser.Student;
                studentUsernameTextbox.Text = student.Name;
                studentPasswordBox.Password = "*****";
                studentCourseCombobox.SelectedItem = studentCourseCombobox.Items
                    .Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Content.ToString() == student.Specialization);
            }
        }

        private void LoadCourses()
        {
            using var db = new AppDbContext();
            var courses = db.Courses.Select(c => c.Name).ToList();
            studentCourseCombobox.Items.Clear();
            foreach (var course in courses)
            {
                studentCourseCombobox.Items.Add(new ComboBoxItem { Content = course });
            }
        }

        private void LoadFavoriteCompanies()
        {
            if (User.LoggedInUser?.StudentId != null)
            {
                using var db = new AppDbContext();
                var favoriteCompanies = db.FavoriteCompanies
                    .Where(f => f.StudentId == User.LoggedInUser.StudentId)
                    .Select(f => f.Stage)
                    .ToList();
                companyListView.ItemsSource = favoriteCompanies;
            }
        }

        private void LoadCompaniesWithMessages()
        {
            if (User.LoggedInUser?.StudentId != null)
            {
                using var db = new AppDbContext();
                var companyIds = db.Messages
                    .Where(m => m.ReceiverStudentId == User.LoggedInUser.StudentId || m.SenderStudentId == User.LoggedInUser.StudentId)
                    .Select(m => m.SenderCompanyId)
                    .Distinct()
                    .ToList();
                var companies = db.Companies
                    .Where(c => companyIds.Contains(c.Id))
                    .ToList();
                companyComboBox.ItemsSource = companies;

                bool hasUnreadMessages = db.Messages
                    .Any(m => m.ReceiverStudentId == User.LoggedInUser.StudentId && !m.IsRead);
                companyComboBox.Background = new SolidColorBrush(hasUnreadMessages ? Colors.Red : Colors.White);
            }
        }

        private void MarkMessagesAsRead(int companyId, int? studentId)
        {
            if (studentId != null)
            {
                using var db = new AppDbContext();
                var unreadMessages = db.Messages
                    .Where(m => m.ReceiverStudentId == studentId && m.SenderCompanyId == companyId && !m.IsRead)
                    .ToList();
                if (unreadMessages.Any())
                {
                    foreach (var message in unreadMessages)
                    {
                        message.IsRead = true;
                    }
                    db.SaveChanges();
                }
            }
        }

        private void companyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (companyComboBox.SelectedItem is Company selectedCompany)
            {
                int companyId = selectedCompany.Id;
                var studentId = User.LoggedInUser.StudentId;
                MarkMessagesAsRead(companyId, studentId);
                Frame.Navigate(typeof(MesagePage), (studentId, companyId, User.LoggedInUser.IsCompany));
                companyComboBox.SelectedItem = null;
                companyComboBox.Background = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void UpdateStudentInfo()
        {
            using var db = new AppDbContext();
            var loggedInUser = User.LoggedInUser;
            var student = db.Students.FirstOrDefault(s => s.Id == loggedInUser.StudentId);
            if (student != null)
            {
                student.Name = studentUsernameTextbox.Text;
                UpdateStudentPassword(student);
                student.Specialization = (studentCourseCombobox.SelectedItem as ComboBoxItem)?.Content.ToString();
                db.SaveChanges();
                UpdateLoggedInUser(student);
                NavigateToMainPage(student);
            }
        }

        private void UpdateStudentPassword(Student student)
        {
            var enteredPassword = studentPasswordBox.Password;
            if (!string.IsNullOrEmpty(enteredPassword) && enteredPassword != "*****")
            {
                if (!SecureHasher.Verify(enteredPassword, student.Password))
                {
                    student.Password = SecureHasher.Hash(enteredPassword);
                }
            }
        }

        private void UpdateLoggedInUser(Student student)
        {
            var loggedInUser = User.LoggedInUser;
            loggedInUser.Student.Name = student.Name;
            loggedInUser.Student.Specialization = student.Specialization;
            DataContext = null;
            DataContext = loggedInUser;
        }

        private void NavigateToMainPage(Student student)
        {
            Frame.Navigate(typeof(MainCurioPage), student);
        }

        private void RemoveFavoriteCompany(int stageId)
        {
            if (User.LoggedInUser?.StudentId != null)
            {
                using var db = new AppDbContext();
                var favorite = db.FavoriteCompanies
                    .FirstOrDefault(f => f.StudentId == User.LoggedInUser.StudentId && f.StageId == stageId);
                if (favorite != null)
                {
                    db.FavoriteCompanies.Remove(favorite);
                    db.SaveChanges();
                    LoadFavoriteCompanies();
                }
            }
        }

        private void DeleteAccountAndNavigate()
        {
            if (User.LoggedInUser != null)
            {
                using var db = new AppDbContext();
                var user = db.Users.FirstOrDefault(u => u.StudentId == User.LoggedInUser.StudentId);
                var student = db.Students.FirstOrDefault(s => s.Id == User.LoggedInUser.StudentId);
                if (user != null) db.Users.Remove(user);
                if (student != null) db.Students.Remove(student);
                db.SaveChanges();
                User.LoggedInUser = null;
                Frame.Navigate(typeof(WelcomePage));
            }
        }

        private void registerNewAccount_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                UpdateStudentInfo();
            }
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrEmpty(studentUsernameTextbox.Text) && studentCourseCombobox.SelectedItem != null;
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainCurioPage));
        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is int companyId)
            {
                RemoveFavoriteCompany(companyId);
            }
        }

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            await deleteDialog.ShowAsync();
        }

        private void deleteDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            DeleteAccountAndNavigate();
        }

        private void uploadFileButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HourCardPage));
        }

        private void solliciteerButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Company company)
            {
                NavigateToApplyPage(company);
            }
        }

        private void NavigateToApplyPage(Company company)
        {
            var student = User.LoggedInUser?.Student;
            Frame.Navigate(typeof(ApplyPage), (company, student, company.Id));
        }
    }
}