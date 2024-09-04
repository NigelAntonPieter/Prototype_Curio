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

        public CompanysList()
        {
            this.InitializeComponent();
            using var db = new AppDbContext();
            var companies = db.Companies.ToList();
            AllCompanies = new ObservableCollection<Company>(companies);
            FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
            companyListView.ItemsSource = FilteredCompanies;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is List<Company> filteredCompanies)
            {
                AllCompanies = new ObservableCollection<Company>(filteredCompanies);
                companyListView.ItemsSource = FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
            }
            else
            {
                // If no filtered companies are passed, initialize with all companies
                FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
                companyListView.ItemsSource = FilteredCompanies;
            }
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }

        private void bContent_Click(object sender, RoutedEventArgs e)
        {
            // Haal de knop die is ingedrukt
            var button = sender as Button;
            var company = button?.DataContext as Company;

            if (company != null)
            {
                // Navigeer naar CompanyOverviewPage en geef de geselecteerde Company door
                this.Frame.Navigate(typeof(CompanyOverviewPage), company);
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
                (bolCheckbox, company => company.LearningPath == "Bol"),
                (bblCheckbox, company => company.LearningPath == "Bbl"),
                (niveau2Checkbox, company => company.Level == 2),
                (niveau3Checkbox, company => company.Level == 3),
                (niveau4Checkbox, company => company.Level == 4),
                (webCheckbox, company => company.Specialization == "Web"),
                (nativeCheckbox, company => company.Specialization == "Native"),
                (frontendCheckbox, company => company.Specialization == "Front-end")
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
