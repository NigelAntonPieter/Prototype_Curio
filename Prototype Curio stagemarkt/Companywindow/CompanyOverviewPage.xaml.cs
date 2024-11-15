using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SharedModel.Data;
using SharedModel.Model;
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
        private int selectedCompanyId;
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

                selectedCompanyId = _currentCompany.Id; 

                companyNameTextblock.Text = company.Name;
                companyCityTextblock.Text = company.City;
                companyLearningPathTextblock.Text = company.LearningPath?.Name ?? "No Learning Path";
                companyLevelTextblock.Text = company.Level?.ToString();
                companyDescriptionTextblock.Text = company.Description;

                DataContext = _currentCompany;

                applyButtonNew.IsEnabled = _currentStudent != null;
            }
            else if (e.Parameter is (Company singleCompany, null))
            {
                _currentCompany = singleCompany;

                selectedCompanyId = _currentCompany.Id; 

                companyNameTextblock.Text = _currentCompany.Name;
                companyCityTextblock.Text = _currentCompany.City;
                companyLearningPathTextblock.Text = _currentCompany.LearningPath?.Name ?? "No Learning Path";
                companyLevelTextblock.Text = _currentCompany.Level?.ToString();
                companyDescriptionTextblock.Text = _currentCompany.Description;

                applyButtonNew.IsEnabled = false;
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


        private void favoriteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void applyButtonNew_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var student = button?.DataContext as Company;
            var company = button?.DataContext as Company;

            if (student != null)
            {
                this.Frame.Navigate(typeof(ApplyPage), (company, _currentStudent, selectedCompanyId));
            }
        }
    }
}