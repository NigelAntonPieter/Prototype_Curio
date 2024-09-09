using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Companywindow;
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

namespace Prototype_Curio_stagemarkt.Stage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CompanysList : Page
    {
        public ObservableCollection<Company> AllCompanies { get; private set; }
        public ObservableCollection<Company> FilteredCompanies { get; private set; }
        private Student _currentStudent;
        private Company _currentCompany;

        public CompanysList()
        {
            this.InitializeComponent();
           LoadCompanies();
        }

        private void LoadCompanies()
        {
            using var db = new AppDbContext();
            var companies = db.Companies
                .Include(c => c.LearningPath) 
                .ToList();
            AllCompanies = new ObservableCollection<Company>(companies);
            FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
            companyListView.ItemsSource = FilteredCompanies;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is (List<Company> filteredCompanies, Student student))
            {
                AllCompanies = new ObservableCollection<Company>(filteredCompanies);
                FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
                companyListView.ItemsSource = FilteredCompanies;
                _currentStudent = student;
            }
            else if (e.Parameter is List<Company> companies)
            {
                AllCompanies = new ObservableCollection<Company>(companies);
                FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
                companyListView.ItemsSource = FilteredCompanies;
                _currentStudent = null; // Or handle accordingly
                
            }
            else
            {
                LoadCompanies();
            }
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }

        private void bContent_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var company = button?.DataContext as Company;

            if (company != null)
            {
                this.Frame.Navigate(typeof(CompanyOverviewPage), (company, _currentStudent));
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ApplyFilter();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            // Maak een lijst van CheckBoxen en bijbehorende filtercriteria
            var filterCriteria = new List<(CheckBox CheckBox, Func<Company, bool> Filter)>
            {
               (bolCheckbox, c => c.LearningPath?.Name == "BOL"),
                (bblCheckbox, c => c.LearningPath?.Name == "BBL"),
                (niveau2Checkbox, c => c.Level == 2),
                (niveau3Checkbox, c => c.Level == 3),
                (niveau4Checkbox, c => c.Level == 4),
                (webCheckbox, c => c.Specialization == "Web"),
                (nativeCheckbox, c => c.Specialization == "Native"),
                (frontendCheckbox, c => c.Specialization == "Front-end")
            };

            var filteredList = AllCompanies.AsEnumerable();

            // Loop door de filtercriteria en pas de filters toe voor geselecteerde CheckBoxen
            foreach (var (checkBox, filter) in filterCriteria)
            {
                if (checkBox.IsChecked == true)
                {
                    filteredList = filteredList.Where(filter);
                }
            }

            // Update de FilteredCompanies ObservableCollection
            FilteredCompanies.Clear();
            foreach (var company in filteredList)
            {
                FilteredCompanies.Add(company);
            }

            UpdateCheckBoxStates();
        }

        private void UpdateCheckBoxStates()
        {
            // Maak een lijst van CheckBoxen en hun uitsluitingscriteria
            var exclusionCriteria = new List<(CheckBox CheckBox, List<CheckBox> Exclude)>
            {
                (bolCheckbox, new List<CheckBox> { bblCheckbox }),
                (bblCheckbox, new List<CheckBox> { bolCheckbox }),

                (niveau2Checkbox, new List<CheckBox> { niveau3Checkbox, niveau4Checkbox }),
                (niveau3Checkbox, new List<CheckBox> { niveau2Checkbox, niveau4Checkbox }),
                (niveau4Checkbox, new List<CheckBox> { niveau2Checkbox, niveau3Checkbox }),

                (nativeCheckbox, new List<CheckBox> { webCheckbox, frontendCheckbox }),
                (webCheckbox, new List<CheckBox> { nativeCheckbox, frontendCheckbox }),
                (frontendCheckbox, new List<CheckBox> { nativeCheckbox, webCheckbox })
            };

            // Zet alle checkboxes weer in
            foreach (var (checkBox, _) in exclusionCriteria)
            {
                checkBox.IsEnabled = true;
            }

            // Loop door de criteria en pas uitsluitingen toe
            foreach (var (checkBox, excludeList) in exclusionCriteria)
            {
                if (checkBox.IsChecked == true)
                {
                    foreach (var exclude in excludeList)
                    {
                        exclude.IsEnabled = false;
                    }
                }
                else
                {
                    foreach (var exclude in excludeList)
                    {
                        // Herstel de state van de uitgesloten checkboxes als ze ingeschakeld waren
                        if (excludeList.All(e => !e.IsChecked == true))
                        {
                            exclude.IsEnabled = true;
                        }
                    }
                }
            }
        }
    }
}
