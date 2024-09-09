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
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Companywindow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CompanyOverviewPage : Page
    {

        private Company _currentCompany;
        private Student _currentStudent;
        public CompanyOverviewPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);

            if (e.Parameter is (Company company, Student student))
            {
                _currentCompany = company;
                _currentStudent = student;

                // Update the UI with company details
                companyNameTextblock.Text = company.Name;
                companyCityTextblock.Text = company.City;
                companyLearningPathTextblock.Text = company.LearningPath?.Name ?? "No Learning Path";
                companyLevelTextblock.Text = company.Level.ToString();
                companyDescriptionTextblock.Text = company.Description;

                // Set the DataContext to the company if needed
                DataContext = _currentCompany;

                // Update button states based on whether a student is logged in
                applyButton.IsEnabled = _currentStudent != null;
                favoriteButton.IsEnabled = _currentStudent != null;
            }
            else if (e.Parameter is (Company singleCompany, null))
            {
                _currentCompany = singleCompany;

                // Update the UI with company details
                companyNameTextblock.Text = _currentCompany.Name;
                companyCityTextblock.Text = _currentCompany.City;
                companyLearningPathTextblock.Text = _currentCompany.LearningPath?.Name ?? "No Learning Path";
                companyLevelTextblock.Text = _currentCompany.Level.ToString();
                companyDescriptionTextblock.Text = _currentCompany.Description;

                // Disable the buttons if no student is logged in
                applyButton.IsEnabled = false;
                favoriteButton.IsEnabled = false;
            }
            else
            {
                return;
            }
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void favoriteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentStudent == null || _currentCompany == null) return;
  
                using var db = new AppDbContext();

                // Controleer of het bedrijf al als favoriet is gemarkeerd
                var existingFavorite = db.FavoriteCompanies
                                         .FirstOrDefault(f => f.StudentId == _currentStudent.Id && f.CompanyId == _currentCompany.Id);

                if (existingFavorite == null)
                {
                    // Voeg het bedrijf toe aan de favorietenlijst
                    db.FavoriteCompanies.Add(new FavoriteCompany
                    {
                        StudentId = _currentStudent.Id,
                        CompanyId = _currentCompany.Id
                    });

                    await db.SaveChangesAsync();

                    await acceptDialog.ShowAsync();
                this.Frame.GoBack();
                }
                else
                {
                   
                    await alreadyDialog.ShowAsync();
                }
        }
    }
}
