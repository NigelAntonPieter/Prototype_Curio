using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using Prototype_Curio_stagemarkt.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Windows.UI.Popups;
using SharedModel.Model;
using SharedModel.Data;
using Microsoft.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

namespace Prototype_Curio_stagemarkt.Stage
{
    public sealed partial class APiList : Page
    {
        private const string ApiUrl = "https://localhost:7249/api/Stages";
        private int _currentPage = 1; 
        private const int _itemsPerPage = 5; 
        private List<StageMarkt> _allStages; 
        private Student _currentStudent;
        private StageMarkt _currentStage;
        private List<StageMarkt> filteredStages;

        public ObservableCollection<StageMarkt> FilteredCompanies { get; private set; }

        public APiList()
        {
            this.InitializeComponent();
            FilteredCompanies = new ObservableCollection<StageMarkt>();
            LoadStages();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Tuple<Student, List<StageMarkt>> navigationData)
            {
                _currentStudent = navigationData.Item1;
                _allStages = navigationData.Item2;
            }
            else if (e.Parameter is Student student)
            {
                _currentStudent = student;
                LoadStages();
            }
            ApplyFilter();  
            DisplayCurrentPage(); 
        }


        private void InitializeCompanies(List<StageMarkt> companies, Student student = null)
        {
            FilteredCompanies.Clear();
            foreach (var company in companies)
            {
                FilteredCompanies.Add(company);
            }

            StagesListView.ItemsSource = FilteredCompanies;
        }



        private async void LoadStages()
        {
            try
            {
                _allStages = await GetStagesAsync();

                // Vul de lijst van stages in FilteredCompanies voor de initiële weergave
                FilteredCompanies.Clear();
                foreach (var stage in _allStages)
                {
                    FilteredCompanies.Add(stage);
                }

                // Na het laden van de stages kunnen we de filter toepassen en de juiste pagina weergeven
                ApplyFilter();  // Dit zorgt ervoor dat de lijst gefilterd wordt op basis van de geselecteerde criteria.
                DisplayCurrentPage();  // Zet de weergave van de pagina in de juiste staat.
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"Error fetching data: {ex.Message}");
            }
        }


        private void StagesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is StageMarkt selectedStage)
            {
                _currentStage = selectedStage;
            }
        }


        private async Task<List<StageMarkt>> GetStagesAsync()
        {
            using HttpClient client = new HttpClient();
            string apiUrl = "https://localhost:7249/api/Stages";

            HttpResponseMessage response = await client.GetAsync(apiUrl); 

            response.EnsureSuccessStatusCode(); 
            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<StageMarkt>>(responseBody);
        }


        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                DisplayCurrentPage(); // Refresh the displayed items
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_allStages.Count / _itemsPerPage);
            if (_currentPage < totalPages)
            {
                _currentPage++;
                DisplayCurrentPage(); // Refresh the displayed items
            }
        }

        private void bContent_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var url = button?.CommandParameter as string;

            if (!string.IsNullOrEmpty(url))
            {
                var uri = new Uri(url, UriKind.Absolute);
                // Launch the URL in the default browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = uri.ToString(),
                    UseShellExecute = true
                });
            }
        }

        private async void bFavorite_Click(object sender, RoutedEventArgs e)
        {
            if (_currentStudent == null)
            {
                Debug.WriteLine("No student is logged in.");
                return;
            }

            var button = sender as Button;
            var selectedStage = button?.CommandParameter as StageMarkt;

            if (selectedStage == null)
            {
                Debug.WriteLine("No stage is selected.");
                return;
            }

            using var db = new CurioContext();

            // Check if the stage is already marked as favorite
            var existingFavorite = db.FavoriteCompanies
                                     .FirstOrDefault(f => f.StudentId == _currentStudent.Id && f.StageId == selectedStage.Id);

            if (existingFavorite == null)
            {
                // Add the stage to the favorites list
                db.FavoriteCompanies.Add(new FavoriteCompany
                {
                    StudentId = _currentStudent.Id,
                    StageId = selectedStage.Id
                });

                await db.SaveChangesAsync();
                await acceptDialog.ShowAsync();
            }
            else
            {
                await alreadyDialog.ShowAsync();
            }
        }

        private void UpdateFilteredCompanies(List<StageMarkt> filtered)
        {
            FilteredCompanies.Clear();
            foreach (var company in filtered)
            {
                FilteredCompanies.Add(company);
            }
        }

        private void ApplyFilter()
        {
            // Begin met de volledige lijst van stages
            filteredStages = _allStages;

            // Filteren op basis van de checkboxen
            if (bolCheckbox.IsChecked == true && bblCheckbox.IsChecked == false)
            {
                filteredStages = filteredStages.Where(stage => stage.Course.ToLower() == "bol").ToList();
            }
            else if (bblCheckbox.IsChecked == true && bolCheckbox.IsChecked == false)
            {
                filteredStages = filteredStages.Where(stage => stage.Course.ToLower() == "bbl").ToList();
            }

            // Controleer of de gefilterde lijst leeg is (voor debugging)
            Debug.WriteLine($"Aantal gefilterde stages: {filteredStages.Count}");

            // Als de lijst leeg is, toon een bericht of pas de weergave aan
            if (filteredStages.Count == 0)
            {
                StagesListView.ItemsSource = null;
                return;
            }

            // Als de lijst niet leeg is, toon dan de huidige pagina
            DisplayCurrentPage();
        }

        private void DisplayCurrentPage()
        {
            if (filteredStages != null && filteredStages.Count > 0)
            {
                // Bereken het totale aantal pagina's
                int totalPages = (int)Math.Ceiling((double)filteredStages.Count / _itemsPerPage);

                // Zorg ervoor dat de huidige pagina binnen de grenzen blijft
                if (_currentPage < 1) _currentPage = 1;
                if (_currentPage > totalPages) _currentPage = totalPages;

                // Verkrijg de items voor de huidige pagina
                var currentItems = filteredStages.Skip((_currentPage - 1) * _itemsPerPage).Take(_itemsPerPage).ToList();
                StagesListView.ItemsSource = currentItems;

                // Zet de pagineringsknoppen in of uit
                PreviousButton.IsEnabled = _currentPage > 1;
                NextButton.IsEnabled = _currentPage < totalPages;
            }
            else
            {
                // Als er geen items zijn, toon een boodschap
                StagesListView.ItemsSource = null;
            }
        }

        private void UpdateCheckBoxStates()
        {
            var exclusionCriteria = new List<(CheckBox CheckBox, List<CheckBox> Exclude)>
            {
                (bolCheckbox, new List<CheckBox> { bblCheckbox }),
                (bblCheckbox, new List<CheckBox> { bolCheckbox }),
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
