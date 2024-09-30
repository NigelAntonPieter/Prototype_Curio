using Microsoft.EntityFrameworkCore;
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
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        private Student selectedStudent;
        private Company selectedCompany;

        public ObservableCollection<Student> AllStudents { get; private set; }

        
        public AdminPage()
        {
            this.InitializeComponent();
            using var db = new AppDbContext();

            LoadCompanies();
            LoadStudents();
        }

        private void LoadCompanies()
        {
            using var db = new AppDbContext();
            var companies = db.Companies.ToList();
            adminCompanyListView.ItemsSource = companies;
        }

        private void LoadStudents()
        {
            using var db = new AppDbContext();
            var students = db.Students.ToList();
            adminStudentListView.ItemsSource = students;
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            this.Frame.Navigate(typeof(WelcomePage));
        }

       

        private async void adminCompanyListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var listViewItem = (FrameworkElement)e.OriginalSource;
            selectedCompany = listViewItem.DataContext as Company;

            if (selectedCompany != null)
            {
                await deleteCompanyDialog.ShowAsync();
            }
        }

        private async void adminStudentListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var listViewItem = (FrameworkElement)e.OriginalSource;
            selectedStudent = listViewItem.DataContext as Student;

            if (selectedStudent != null)
            {
                await deleteStudentDialog.ShowAsync();
            }
        }

        private async void deleteStudentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (selectedStudent != null)
            {
                using var db = new AppDbContext();

                var selectedUserStudent = db.Users.FirstOrDefault(u => u.StudentId == selectedStudent.Id);
                db.Students.Remove(selectedStudent);

                if (selectedUserStudent != null)
                {
                    db.Users.Remove(selectedUserStudent);
                }

                try
                {
                    await db.SaveChangesAsync();
                    this.Frame.Navigate(typeof(AdminPage));
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    foreach (var entry in ex.Entries)
                    {
                        var proposedValues = entry.CurrentValues;
                        var databaseValues = entry.GetDatabaseValues();

                        if (databaseValues == null)
                        {
                            await databaseErrorDialog.ShowAsync();
                        }
                        else
                        {
                            throw ex;
                        }
                    }
                }
            }
        }

        private async void deleteCompanyDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (selectedCompany != null)
            {
                using var db = new AppDbContext();

                var selectedUserCompany = db.Users.FirstOrDefault(u => u.CompanyId == selectedCompany.Id);
                var selectedFavoriteCompany = db.FavoriteCompanies.FirstOrDefault(f => f.CompanyId == selectedCompany.Id);

                db.Companies.Remove(selectedCompany);

                if (selectedUserCompany != null)
                {
                    db.Users.Remove(selectedUserCompany);
                }

                if (selectedFavoriteCompany != null)
                {
                    db.FavoriteCompanies.Remove(selectedFavoriteCompany);
                }

                try
                {
                    await db.SaveChangesAsync();
                    this.Frame.Navigate(typeof(AdminPage));
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    foreach (var entry in ex.Entries)
                    {
                        var proposedValues = entry.CurrentValues;
                        var databaseValues = entry.GetDatabaseValues();

                        if (databaseValues == null)
                        {
                            await databaseErrorDialog.ShowAsync();
                        }
                        else
                        {
                            throw ex;
                        }
                    }
                }
            }
        }

        private async void adminCompanyListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedCompany = e.ClickedItem as Company;

            if (clickedCompany != null)
            {
                using var db = new AppDbContext();
                var user = db.Users.FirstOrDefault(u => u.CompanyId == clickedCompany.Id);

                if (user != null)
                {
                    // Update de TextBlocks in het ContentDialog met de bedrijfsnaam en laatste inlogtijd
                    companyNameTextBlock.Text = clickedCompany.Name;
                    companyLastLoginTextBlock.Text = user.LastLogin.HasValue
                        ? user.LastLogin.Value.ToString("dd-MM-yyyy HH:mm")
                        : "Nooit ingelogd";

                    // Toon het dialoogvenster
                    await companyInfoDialog.ShowAsync();
                }
            }
        }

        private async void adminStudentListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedStudent = e.ClickedItem as Student;

            if (clickedStudent != null)
            {
                using var db = new AppDbContext();
                var user = db.Users.FirstOrDefault(u => u.StudentId == clickedStudent.Id);

                if (user != null)
                {
                    // Update de TextBlocks in het ContentDialog met de studentnaam en laatste inlogtijd
                    studentNameTextBlock.Text = clickedStudent.Name;
                    studentLastLoginTextBlock.Text = user.LastLogin.HasValue
                        ? user.LastLogin.Value.ToString("dd-MM-yyyy HH:mm")
                        : "Nooit ingelogd";

                    // Toon het dialoogvenster
                    await studentInfoDialog.ShowAsync();
                }
            }
        }
    }
}
