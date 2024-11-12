using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Main;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage;
using WinRT.Interop;
using SharedModel.Model;
using SharedModel.Data;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.NewAccount;
using Microsoft.UI.Text;
using Microsoft.UI;
using Windows.UI.Text;
using System.Diagnostics;
using Prototype_Curio_stagemarkt.AdminMap;
using System.Xml.Linq;

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
        private StorageFile copiedFile;
        private int _applicationCount;
        private SharedModel.Model.Application selectedApplication;

        public AccountCompanyPage()
        {
            InitializeComponent();
            LoadCourses();
            LoadLevels();

            applicationListView.SelectionChanged += applicationListView_SelectionChanged;

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var companyId = e.Parameter as int?;
            if (User.LoggedInUser != null && User.LoggedInUser.CompanyId.HasValue)
            {
                companyId = User.LoggedInUser.CompanyId.Value;

                await LoadCompanyData(companyId.Value);
                await LoadApplications(companyId.Value);
                await CheckForUnreadMessages(companyId.Value);
            }
            else
            {
                await noCompanyDialog.ShowAsync();
            }
        }


        private async Task LoadCompanyData(int companyId)
        {
            using var db = new CurioContext();
            var company = await db.Companies
                                  .Include(c => c.Level)
                                  .Include(c => c.LearningPath)
                                  .FirstOrDefaultAsync(c => c.Id == companyId);

            if (company != null)
            {
                SetCompanyDetailsInUI(company);
            }
        }

        private async Task LoadApplications(int companyId)
        {
            using var db = new CurioContext();
            var applications = await db.Applications
                                       .Include(a => a.Student)
                                       .Where(a => a.CompanyId == companyId)
                                       .ToListAsync();

            _applicationCount = applications.Count;
            UpdateApplicationCount();

            applicationListView.ItemsSource = applications;
        }

        private void LoadLevels()
        {
            using var db = new CurioContext();
            var levels = db.Levels.ToList();
            companyLevelCombobox.Items.Clear();
            foreach (var level in levels)
            {
                companyLevelCombobox.Items.Add(new ComboBoxItem { Content = level.GradeLevel, DataContext = level });
            }
        }

        private void LoadCourses()
        {
            using var db = new CurioContext();
            var courses = db.Courses.Select(c => c.Name).ToList();
            companyCourseCombobox.Items.Clear();
            foreach (var course in courses)
            {
                companyCourseCombobox.Items.Add(new ComboBoxItem { Content = course });
            }
        }

  
        private void SetCompanyDetailsInUI(Company company)
        {
            companyNameTextbox.Text = company.Name;
            companyPasswordBox.Password = "*****";
            companyEmailTextbox.Text = company.EmailAddress;
            companyPhoneTextbox.Text = company.Phone;
            companyStreetTextbox.Text = company.Street;
            companyCityTextbox.Text = company.City;
            companyDescriptionTextbox.Text = company.Description;

            companyLevelCombobox.SelectedItem = companyLevelCombobox.Items
                .Cast<ComboBoxItem>()
                .FirstOrDefault(item => (item.DataContext as Level)?.GradeLevel == company.Level.GradeLevel);

            companyLearningPathTextbox.Text = company.LearningPath?.Name ?? "Geen leerweg";

            companyCourseCombobox.SelectedItem = companyCourseCombobox.Items
                .Cast<ComboBoxItem>()
                .FirstOrDefault(item => item.Content.ToString() == company.Specialization);

            isPlaceOpen.IsChecked = company.IsOpen;
        }

        private void UpdateApplicationCount()
        {
            applicationCountTextBlock.Text = $"Sollicitanten: {_applicationCount}";
        }

        private async Task CheckForUnreadMessages(int companyId)
        {
            using var db = new CurioContext();
            var unreadMessages = await db.Messages
                                          .Where(m => m.ReceiverCompanyId == companyId && !m.IsRead)
                                          .Include(m => m.SenderStudent) 
                                          .ToListAsync();

            int unreadMessageCount = unreadMessages.Count;

            if (unreadMessageCount > 0)
            {

                messageNotificationIcon.Visibility = Visibility.Visible;
                messageNotificationIcon.Text = $"{unreadMessageCount} New Message(s)";

                // List the senders
                var senderNames = unreadMessages
                    .Select(m => m.SenderStudent?.Name)
                    .Where(name => !string.IsNullOrEmpty(name))
                    .Distinct(); 

                messageNotificationDetails.Text = "From: " + string.Join(", ", senderNames);
            }
            else
            {
                messageNotificationIcon.Visibility = Visibility.Visible;
                messageNotificationIcon.Text = "0 New Messages";
                messageNotificationDetails.Text = string.Empty; 
            }
        }


        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            this.Frame.Navigate(typeof(WelcomePage));
        }

        private async void registerCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateCompanyInput())
            {
                await fiedsDialog.ShowAsync();
                return;
            }

            if (User.LoggedInUser is User loggedInCompany)
            {
                await UpdateCompany(loggedInCompany);
            }
        }

        private async void fileButton_Click(object sender, RoutedEventArgs e)
        {
            await SelectAndCopyFileAsync();
        }

        private async void applicationListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (applicationListView.SelectedItem is Student selectedStudent)
            {
                int studentId = selectedStudent.Id;
                var companyId = User.LoggedInUser.CompanyId;

                await MarkMessagesAsRead(companyId, studentId);

                Frame.Navigate(typeof(MesagePage), (studentId, companyId, User.LoggedInUser.IsCompany));
                applicationListView.SelectedItem = null;
                applicationListView.Background = new SolidColorBrush(Colors.Transparent);
            }
        }

        private async void applicationListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var listViewItem = (FrameworkElement)e.OriginalSource;
            selectedApplication = listViewItem.DataContext as SharedModel.Model.Application;

            if (selectedApplication != null)
            {
                await deleteApplicationDialog.ShowAsync();
            }
        }

        private async void applicationListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is SharedModel.Model.Application application)
            {
                int? studentId = application.StudentId;
                int companyId = application.CompanyId;

                if (studentId.HasValue && companyId > 0)
                {
                    await MarkMessagesAsRead(companyId, studentId.Value);
                    Frame.Navigate(typeof(MesagePage), (studentId, companyId, User.LoggedInUser.IsCompany));
                }
                else
                {
                    Debug.WriteLine("Navigation failed due to missing student or company ID.");
                }
            }
        }

        private async void deleteApplicationDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (selectedApplication != null)
            {
                using var db = new CurioContext();


                var existingTrackedApp = db.Applications.Local.FirstOrDefault(a => a.Id == selectedApplication.Id);
                if (existingTrackedApp != null)
                {
                    db.Entry(existingTrackedApp).State = EntityState.Detached;
                }

                db.Applications.Remove(selectedApplication);

                try
                {
                    await db.SaveChangesAsync();

                    var applications = applicationListView.ItemsSource as List<SharedModel.Model.Application>;
                    if (applications != null)
                    {
                        applications.Remove(selectedApplication);
                        applicationListView.ItemsSource = null;
                        applicationListView.ItemsSource = applications;
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {

                    foreach (var entry in ex.Entries)
                    {
                        var proposedValues = entry.CurrentValues;
                        var databaseValues = entry.GetDatabaseValues();

                        if (databaseValues == null)
                        {

                        }
                    }
                }
            }
        }

        // HELPER METHODS // 

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



        private async Task UpdateCompany(User loggedInCompany)
        {
            using var db = new CurioContext();
            var company = db.Companies.Include(c => c.Level).FirstOrDefault(c => c.Id == loggedInCompany.CompanyId);

            if (company != null)
            {
                UpdateCompanyDetails(company, db);

                db.SaveChanges();

                UpdateUserDetails(loggedInCompany, company);

                this.DataContext = null;
                this.DataContext = User.LoggedInUser;
                this.Frame.Navigate(typeof(AccountCompanyPage), company);
            }
        }

        private void UpdateCompanyDetails(Company company, CurioContext db)
        {
            var selectedLevel = (companyLevelCombobox.SelectedItem as ComboBoxItem)?.DataContext as Level;
            company.Level = selectedLevel != null && db.Levels.Find(selectedLevel.Id) != null
                ? db.Levels.Find(selectedLevel.Id)
                : selectedLevel;

            var learningPath = db.LearningPaths.FirstOrDefault(lp => lp.Name == companyLearningPathTextbox.Text);
            company.LearningPath = learningPath ?? company.LearningPath;

            company.Specialization = (companyCourseCombobox.SelectedItem as ComboBoxItem)?.Content.ToString();
            company.Name = companyNameTextbox.Text;
            company.Phone = companyPhoneTextbox.Text;
            company.EmailAddress = companyEmailTextbox.Text;
            company.Street = companyStreetTextbox.Text;
            company.City = companyCityTextbox.Text;
            company.Description = companyDescriptionTextbox.Text;
            company.IsOpen = isPlaceOpen.IsChecked == true;
            company.ImagePath = copiedFile?.Path;

            if (!string.IsNullOrEmpty(companyPasswordBox.Password) && companyPasswordBox.Password != "*****")
            {
                if (!SecureHasher.Verify(companyPasswordBox.Password, company.Password))
                {
                    company.Password = SecureHasher.Hash(companyPasswordBox.Password);
                }
            }
        }

        private void UpdateUserDetails(User loggedInCompany, Company company)
        {
            loggedInCompany.Company.Name = company.Name;
            loggedInCompany.Company.Specialization = company.Specialization;
            loggedInCompany.Company.Phone = company.Phone;
            loggedInCompany.Company.EmailAddress = company.EmailAddress;
            loggedInCompany.Company.Street = company.Street;
            loggedInCompany.Company.City = company.City;
            loggedInCompany.Company.Description = company.Description;
        }

        private bool ValidateCompanyInput()
        {
            return !(string.IsNullOrEmpty(companyNameTextbox.Text) ||
                     string.IsNullOrEmpty(companyPhoneTextbox.Text) ||
                     string.IsNullOrEmpty(companyEmailTextbox.Text) ||
                     string.IsNullOrEmpty(companyStreetTextbox.Text) ||
                     string.IsNullOrEmpty(companyCityTextbox.Text) ||
                     string.IsNullOrEmpty(companyDescriptionTextbox.Text) ||
                     companyLevelCombobox.SelectedItem == null ||
                     string.IsNullOrEmpty(companyLearningPathTextbox.Text) ||
                     companyCourseCombobox.SelectedItem == null);
        }

        private void isPlaceOpen_Unchecked(object sender, RoutedEventArgs e)
        {
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

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            await deleteDialog.ShowAsync();
        }

        private void deleteDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (User.LoggedInUser != null)
            {
                using var db = new CurioContext();

                if (User.LoggedInUser.CompanyId.HasValue)
                {
                    var user = db.Users.FirstOrDefault(u => u.CompanyId == User.LoggedInUser.CompanyId);
                    if (user != null)
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }

                    var company = db.Companies.FirstOrDefault(c => c.Id == User.LoggedInUser.CompanyId);
                    if (company != null)
                    {
                        db.Companies.Remove(company);
                        db.SaveChanges();
                    }
                }
                User.LoggedInUser = null;
                this.Frame.Navigate(typeof(WelcomePage));
            }
            else
            {
                this.Frame.GoBack();
            }
        }

        private async void CvLinkTextBlock_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (sender is TextBlock cvLinkTextBlock && cvLinkTextBlock.Tag is string cvFilePath)
            {
                var file = await StorageFile.GetFileFromPathAsync(cvFilePath);
                if (file != null)
                {
                    await Windows.System.Launcher.LaunchFileAsync(file);
                }
            }
        }

        private async Task MarkMessagesAsRead(int? companyId, int studentId)
        {
            if (companyId != null)
            {
                using var db = new CurioContext();

                var unreadMessages = db.Messages
                                        .Where(m => m.ReceiverCompanyId == companyId && m.SenderStudentId == studentId && !m.IsRead)
                                        .ToList();

                if (unreadMessages.Any())
                {
                    foreach (var message in unreadMessages)
                    {
                        message.IsRead = true;
                    }

                    await db.SaveChangesAsync();

                    await CheckForUnreadMessages(companyId.Value);

                    // Refresh DataContext
                    this.DataContext = null;
                    this.DataContext = User.LoggedInUser;
                }
            }
        }
    }
}
