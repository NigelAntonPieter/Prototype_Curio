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

namespace Prototype_Curio_stagemarkt.Stage
{
    public sealed partial class APiList : Page
    {
        private const string ApiUrl = "https://localhost:7249/api/Stages"; // Change to your actual API URL
        private int _currentPage = 1; // Current page index
        private const int _itemsPerPage = 5; // Number of items per page
        private List<StageMarkt> _allStages; // Store all fetched stages
        private Student _currentStudent;
        private StageMarkt _currentStage;

        public APiList()
        {
            this.InitializeComponent();
            LoadStages();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Tuple<Student, List<StageMarkt>> navigationData)
            {
                _currentStudent = navigationData.Item1;  // Assign logged-in student
                _allStages = navigationData.Item2;       // Assign filtered stages if available
            }
            else if (e.Parameter is Student student)
            {
                _currentStudent = student;  // Assign logged-in student
                LoadStages();               // Load all stages if no search results are provided
            }

            DisplayCurrentPage();  // Update the UI with the filtered data
        }





        private async void LoadStages()
        {
            try
            {
                _allStages = await GetStagesAsync();
                DisplayCurrentPage();
            }
            catch (HttpRequestException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error fetching data: {ex.Message}");
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


        private void DisplayCurrentPage()
        {
            if (_allStages != null)
            {
                // Calculate the total number of pages
                int totalPages = (int)Math.Ceiling((double)_allStages.Count / _itemsPerPage);

                // Ensure the current page is within bounds
                if (_currentPage < 1) _currentPage = 1;
                if (_currentPage > totalPages) _currentPage = totalPages;

                // Get the items for the current page
                var currentItems = _allStages.Skip((_currentPage - 1) * _itemsPerPage).Take(_itemsPerPage).ToList();
                StagesListView.ItemsSource = currentItems;

                // Enable/disable pagination buttons
                PreviousButton.IsEnabled = _currentPage > 1;
                NextButton.IsEnabled = _currentPage < totalPages;
            }
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
                Debug.WriteLine("Stage added to favorites.");
            }
            else
            {
                Debug.WriteLine("Stage is already in favorites.");
            }
        }
    }
}
