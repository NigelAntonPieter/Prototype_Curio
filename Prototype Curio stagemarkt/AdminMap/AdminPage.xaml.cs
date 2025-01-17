using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SharedModel.Model;
using SharedModel.Data;
using Prototype_Curio_stagemarkt.Data;
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

namespace Prototype_Curio_stagemarkt.AdminMap
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        private Student selectedStudent;
        private Company selectedCompany;

        public ObservableCollection<Student> AllStudents { get; private set; }
        public ObservableCollection<Company> AllCompanies { get; private set; }


        public AdminPage()
        {
            this.InitializeComponent();
            using var db = new CurioContext();

            AllCompanies = new ObservableCollection<Company>();
            AllStudents = new ObservableCollection<Student>();

            LoadCompanies();
            LoadStudents();
        }

        private void LoadCompanies()
        {
            using var db = new CurioContext();
            var companies = db.Companies.ToList();
            foreach (var company in companies)
            {
                AllCompanies.Add(company); 
            }
        }

        private void LoadStudents()
        {
            using var db = new CurioContext();
            var students = db.Students.ToList();
            foreach (var student in students)
            {
                AllStudents.Add(student); 
            }
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            this.Frame.Navigate(typeof(WelcomePage));
        }

        private async void adminCompanyGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedCompany = e.ClickedItem as Company;

            if (clickedCompany != null)
            {
                using var db = new CurioContext();
                var user = db.Users.FirstOrDefault(u => u.CompanyId == clickedCompany.Id);

                if (user != null)
                {
                    // Update de TextBlocks in het ContentDialog met de bedrijfsnaam en laatste inlogtijd
                    companyNameTextBlock.Text = clickedCompany.Name;
                    companyEmailTextBlock.Text = clickedCompany.EmailAddress;
                    companyLastLoginTextBlock.Text = user.LastLogin.HasValue
                        ? user.LastLogin.Value.ToString("dd-MM-yyyy HH:mm")
                        : "Nooit ingelogd";

                    // Toon het dialoogvenster
                    await companyInfoDialog.ShowAsync();
                }
            }
        }

        private async void adminStudentGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedStudent = e.ClickedItem as Student;

            if (clickedStudent != null)
            {
                using var db = new CurioContext();
                var user = db.Users.FirstOrDefault(u => u.StudentId == clickedStudent.Id);

                if (user != null)
                {
                    // Update de TextBlocks in het ContentDialog met de studentnaam en laatste inlogtijd
                    studentNameTextBlock.Text = clickedStudent.Name;
                    studentEmailTextBlock.Text  = clickedStudent.EmailAddress;
                    studentLastLoginTextBlock.Text = user.LastLogin.HasValue
                        ? user.LastLogin.Value.ToString("dd-MM-yyyy HH:mm")
                        : "Nooit ingelogd";

                    // Toon het dialoogvenster
                    await studentInfoDialog.ShowAsync();
                }
            }
        }

        private async void adminCompanyGridView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var gridViewItem = (FrameworkElement)e.OriginalSource;
            selectedCompany = gridViewItem.DataContext as Company;

            if (selectedCompany != null)
            {
                await deleteCompanyDialog.ShowAsync();
            }
        }

        private async void adminStudentGridView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var gridViewItem = (FrameworkElement)e.OriginalSource;
            selectedStudent = gridViewItem.DataContext as Student;

            if (selectedStudent != null)
            {
                await deleteStudentDialog.ShowAsync();
            }
        }

        private async void deleteStudentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (selectedStudent != null)
            {
                using var db = new CurioContext();

                // Verwijder berichten die gekoppeld zijn aan deze student
                var relatedMessages = db.Messages.Where(m => m.SenderStudentId == selectedStudent.Id || m.ReceiverStudentId == selectedStudent.Id);
                db.Messages.RemoveRange(relatedMessages);

                // Verwijder gekoppelde gebruiker
                var selectedUserStudent = db.Users.FirstOrDefault(u => u.StudentId == selectedStudent.Id);

                if (selectedUserStudent != null)
                {
                    db.Users.Remove(selectedUserStudent);
                }

                // Verwijder de student
                db.Students.Remove(selectedStudent);

                try
                {
                    await db.SaveChangesAsync();
                    this.Frame.Navigate(typeof(AdminPage));
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    foreach (var entry in ex.Entries)
                    {
                        if (entry.GetDatabaseValues() == null)
                        {
                            await databaseErrorDialog.ShowAsync();
                        }
                    }
                }
            }
        }


        private async void deleteCompanyDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (selectedCompany != null)
            {
                using var db = new CurioContext();

                // Verwijder berichten die gekoppeld zijn aan dit bedrijf
                var relatedMessages = db.Messages.Where(m => m.SenderCompanyId == selectedCompany.Id || m.ReceiverCompanyId == selectedCompany.Id);
                db.Messages.RemoveRange(relatedMessages);

                // Verwijder gekoppelde gebruiker en favoriete bedrijven
                var selectedUserCompany = db.Users.FirstOrDefault(u => u.CompanyId == selectedCompany.Id);
                var selectedFavoriteCompany = db.FavoriteCompanies.FirstOrDefault(f => f.Stage.Id == selectedCompany.Id);

                if (selectedUserCompany != null)
                {
                    db.Users.Remove(selectedUserCompany);
                }

                if (selectedFavoriteCompany != null)
                {
                    db.FavoriteCompanies.Remove(selectedFavoriteCompany);
                }

                // Verwijder het bedrijf
                db.Companies.Remove(selectedCompany);

                try
                {
                    await db.SaveChangesAsync();
                    this.Frame.Navigate(typeof(AdminPage));
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    foreach (var entry in ex.Entries)
                    {
                        if (entry.GetDatabaseValues() == null)
                        {
                            await databaseErrorDialog.ShowAsync();
                        }
                    }
                }
            }
        }


        private void searchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchInput = searchTextbox.Text;

            using var db = new CurioContext();
        }
    }
}
