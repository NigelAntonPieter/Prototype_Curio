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
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.NewAccount;
using Microsoft.UI.Text;
using Microsoft.UI;
using Windows.UI.Text;
using System.Diagnostics;

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

        public AccountCompanyPage()
        {
            InitializeComponent();
            LoadCourses();
            LoadLevels();
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var companyId = e.Parameter as int?;
            if (User.LoggedInUser != null && User.LoggedInUser.CompanyId.HasValue)
            {
                companyId = User.LoggedInUser.CompanyId.Value;

                using var db = new AppDbContext();
                var applications = await db.Applications
                                           .Include(a => a.Student)
                                           .Where(a => a.CompanyId == companyId)
                                           .ToListAsync();

                _applicationCount = applications.Count;
                UpdateApplicationCount();
            }

            if (companyId.HasValue)
            {
                using var db = new AppDbContext();
                var company = db.Companies
                                 .Include(c => c.Level)
                                .Include(c => c.LearningPath)
                                .FirstOrDefault(c => c.Id == companyId.Value);

                if (company != null)
                {
                    companyNameTextbox.Text = company.Name;
                    companyPasswordBox.Password = "*****";
                    companyEmailTextbox.Text = company.EmailAddress;
                    companyPhoneTextbox.Text = company.Phone;
                    companyStreetTextbox.Text = company.Street;
                    companyCityTextbox.Text = company.City;
                    companyDescriptionTextbox.Text = company.Description;
                    companyLevelCombobox.SelectedItem = companyLevelCombobox.Items.
                        Cast<ComboBoxItem>()
                      .FirstOrDefault(item => (item.DataContext as Level)?.GradeLevel == company.Level.GradeLevel);
                    companyLearningPathTextbox.Text = company.LearningPath?.Name ?? "Geen leerweg";
                    companyCourseCombobox.SelectedItem = companyCourseCombobox.Items
                     .Cast<ComboBoxItem>()
                     .FirstOrDefault(item => item.Content.ToString() == company.Specialization);
                    isPlaceOpen.IsChecked = company.IsOpen;

                    var applications = await db.Applications
                        .Where(a => a.CompanyId == companyId.Value)
                        .ToListAsync();

                    applicationListView.ItemsSource = applications;
                }
                else
                {
                    await noCompanyDialog.ShowAsync();
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void UpdateApplicationCount()
        {
            applicationCountTextBlock.Text = $"Sollicitanten: {_applicationCount}";
        }
        private void LoadCourses()
        {
            using var db = new AppDbContext();
            var courses = db.Courses.Select(c => c.Name).ToList();
            companyCourseCombobox.Items.Clear();
            foreach (var course in courses)
            {
                companyCourseCombobox.Items.Add(new ComboBoxItem { Content = course });
            }
        }

        private void LoadLevels()
        {
            using var db = new AppDbContext();
            var levels = db.Levels.ToList();
            companyLevelCombobox.Items.Clear();
            foreach (var level in levels)
            {
                companyLevelCombobox.Items.Add(new ComboBoxItem { Content = level.GradeLevel, DataContext = level });
            }
        }



        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            this.Frame.Navigate(typeof(WelcomePage));
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

        private async void registerCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            using var db = new AppDbContext();

            if (string.IsNullOrEmpty(companyNameTextbox.Text) ||
                string.IsNullOrEmpty(companyPhoneTextbox.Text) ||
                string.IsNullOrEmpty(companyEmailTextbox.Text) ||
                string.IsNullOrEmpty(companyStreetTextbox.Text) ||
                string.IsNullOrEmpty(companyCityTextbox.Text) ||
                string.IsNullOrEmpty(companyDescriptionTextbox.Text) ||
                companyLevelCombobox.SelectedItem == null ||
                string.IsNullOrEmpty(companyLearningPathTextbox.Text) ||
                companyCourseCombobox.SelectedItem == null)
            {
                await fiedsDialog.ShowAsync();
                return;
            }

            if (User.LoggedInUser is User loggedInCompany)
            {
                var company = db.Companies.Include(c => c.Level).FirstOrDefault(c => c.Id == loggedInCompany.CompanyId);

                if (company != null)
                {
                    var selectedLevel = (companyLevelCombobox.SelectedItem as ComboBoxItem)?.DataContext as Level;

                    if (selectedLevel != null)
                    {
                        var existingLevel = await db.Levels.FindAsync(selectedLevel.Id);
                        if (existingLevel != null)
                        {
                            company.Level = existingLevel;
                        }
                        else
                        {
                            company.Level = selectedLevel;
                        }
                    }

                    var learningPath = db.LearningPaths.FirstOrDefault(lp => lp.Name == companyLearningPathTextbox.Text);

                    if (learningPath != null)
                    {
                        company.LearningPath = learningPath;
                    }
                    else
                    {
                        return;
                    }

                    var selectedCourse = (companyCourseCombobox.SelectedItem as ComboBoxItem)?.Content.ToString();
                    company.Specialization = selectedCourse; 

                    string enteredPassword = companyPasswordBox.Password;

                    if (!string.IsNullOrEmpty(enteredPassword) && enteredPassword != "*****")
                    {
                        if (!SecureHasher.Verify(enteredPassword, company.Password))
                        {
                            company.Password = SecureHasher.Hash(enteredPassword);
                        }
                    }

                    company.Name = companyNameTextbox.Text;
                    company.Phone = companyPhoneTextbox.Text;
                    company.EmailAddress = companyEmailTextbox.Text;
                    company.Street = companyStreetTextbox.Text;
                    company.City = companyCityTextbox.Text;
                    company.Description = companyDescriptionTextbox.Text;
                    company.IsOpen = isPlaceOpen.IsChecked == true;
                    company.ImagePath = copiedFile?.Path;

                    db.SaveChanges();  

                    User.LoggedInUser.Company.Name = company.Name;
                    User.LoggedInUser.Company.Specialization = company.Specialization;
                    User.LoggedInUser.Company.Phone = company.Phone;
                    User.LoggedInUser.Company.EmailAddress = company.EmailAddress;
                    User.LoggedInUser.Company.Street = company.Street;
                    User.LoggedInUser.Company.City = company.City;
                    User.LoggedInUser.Company.Description = company.Description;

                    this.DataContext = null;
                    this.DataContext = User.LoggedInUser;

                    this.Frame.Navigate(typeof(AccountCompanyPage), company);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
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

        
        private async void CvLinkTextBlock_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            var cvLinkTextBlock = sender as TextBlock;
            var cvFilePath = cvLinkTextBlock.Text;

            if (!string.IsNullOrEmpty(cvFilePath))
            {
                var file = await StorageFile.GetFileFromPathAsync(cvFilePath);
                if (file != null)
                {
                    await Windows.System.Launcher.LaunchFileAsync(file);
                }
            }
        }


        private void deleteDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (User.LoggedInUser != null)
            {
                using var db = new AppDbContext();

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

        private void applicationListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var originalSource = e.OriginalSource as FrameworkElement;

            while (originalSource != null && originalSource.DataContext == null)
            {
                originalSource = VisualTreeHelper.GetParent(originalSource) as FrameworkElement;
            }

            var application = originalSource?.DataContext as Prototype_Curio_stagemarkt.Data.Models.Application;

            if (application != null)
            {
                this.Frame.Navigate(typeof(MesagePage), (application.StudentId, application.CompanyId, User.LoggedInUser.IsCompany));
            }
        }

    }
}
