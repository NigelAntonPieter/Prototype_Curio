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
using Prototype_Curio_stagemarkt.Data.Model;
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

        public CompanysList()
        {
            InitializeComponent();
            LoadCompanies();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is (List<Company> filteredCompanies, Student student))
            {
                InitializeCompanies(filteredCompanies, student);
            }
            else if (e.Parameter is List<Company> companies)
            {
                InitializeCompanies(companies);
            }
            else
            {
                LoadCompanies();
            }
        }

        private void InitializeCompanies(List<Company> companies, Student student = null)
        {
            AllCompanies = new ObservableCollection<Company>(companies);
            FilteredCompanies = new ObservableCollection<Company>(AllCompanies);
            _currentStudent = student;

            if (_currentStudent != null)
            {
                FilterCompaniesBySpecialization(_currentStudent.Specialization);
            }

            companyListView.ItemsSource = FilteredCompanies;
        }

        private void LoadCompanies()
        {
            using var db = new AppDbContext();

            var companies = db.Companies
                .Include(c => c.LearningPath)
                .Include(c => c.Level)
                .Where(c => c.IsOpen && c.Level != null)
                .ToList();

            if (_currentStudent != null)
            {
                companies = companies.Where(c => c.Specialization == _currentStudent.Specialization).ToList();
            }

            InitializeCompanies(companies);
        }

        private void FilterCompaniesBySpecialization(string specialization)
        {
            if (string.IsNullOrEmpty(specialization)) return;

            var filtered = AllCompanies.Where(c => c.Specialization == specialization).ToList();
            UpdateFilteredCompanies(filtered);
        }

        private void UpdateFilteredCompanies(List<Company> filtered)
        {
            FilteredCompanies.Clear();
            foreach (var company in filtered)
            {
                FilteredCompanies.Add(company);
            }
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainCurioPage));
        }

        private void bContent_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Company company)
            {
                Frame.Navigate(typeof(CompanyOverviewPage), (company, _currentStudent));
            }
        }

        private void ApplyFilter()
        {
            var filteredList = AllCompanies.AsEnumerable();

            // Filteren op specialisatie van de student
            if (!string.IsNullOrEmpty(_currentStudent?.Specialization))
            {
                filteredList = filteredList.Where(c => c.Specialization == _currentStudent.Specialization);
            }

            // Checkbox filters toepassen
            var filterCriteria = new List<(CheckBox CheckBox, Func<Company, bool> Filter)>
            {
                (bolCheckbox, c => c.LearningPath?.Name == "BOL"),
                (bblCheckbox, c => c.LearningPath?.Name == "BBL"),
                (niveau2Checkbox, c => c.LevelId == 1),
                (niveau3Checkbox, c => c.LevelId == 2),
                (niveau4Checkbox, c => c.LevelId == 3)
            };

            foreach (var (checkBox, filter) in filterCriteria)
            {
                if (checkBox.IsChecked == true)
                {
                    filteredList = filteredList.Where(filter);
                }
            }

            UpdateFilteredCompanies(filteredList.ToList());

            UpdateCheckBoxStates();
        }


        private void UpdateCheckBoxStates()
        {
            var exclusionCriteria = new List<(CheckBox CheckBox, List<CheckBox> Exclude)>
        {
            (bolCheckbox, new List<CheckBox> { bblCheckbox }),
            (bblCheckbox, new List<CheckBox> { bolCheckbox }),
            (niveau2Checkbox, new List<CheckBox> { niveau3Checkbox, niveau4Checkbox }),
            (niveau3Checkbox, new List<CheckBox> { niveau2Checkbox, niveau4Checkbox }),
            (niveau4Checkbox, new List<CheckBox> { niveau2Checkbox, niveau3Checkbox })
        };

            foreach (var (checkBox, excludeList) in exclusionCriteria)
            {
                UpdateCheckBoxAvailability(checkBox, excludeList);
            }
        }

        private void UpdateCheckBoxAvailability(CheckBox checkBox, List<CheckBox> excludeList)
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
                    if (excludeList.All(e => e.IsChecked != true))
                    {
                        exclude.IsEnabled = true;
                    }
                }
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => ApplyFilter();

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e) => ApplyFilter();
    }
}
