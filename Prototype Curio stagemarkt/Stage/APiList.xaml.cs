using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Stage
{
    public sealed partial class APiList : Page
    {
        private const string ApiUrl = "https://localhost:7249/api/Stages"; // Change to your actual API URL
        private int _currentPage = 1; // Current page index
        private const int _itemsPerPage = 5; // Number of items per page
        private List<Stage> _allStages; // Store all fetched stages

        public APiList()
        {
            this.InitializeComponent();
            LoadStages();
        }

        private async void LoadStages()
        {
            try
            {
                _allStages = await GetStagesAsync(); // Fetch all stages from the API
                DisplayCurrentPage();
            }
            catch (HttpRequestException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error fetching data: {ex.Message}");
            }
        }

        private async Task<List<Stage>> GetStagesAsync()
        {
            using HttpClient client = new HttpClient();
            string apiUrl = "https://localhost:7249/api/Stages"; // Ensure this URL is correct

            HttpResponseMessage response = await client.GetAsync(apiUrl); // Make sure to use GetAsync

            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not success
            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Stage>>(responseBody);
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
    }

    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }      // Voeg de Date-eigenschap toe
        public string Place { get; set; }     // Voeg de Place-eigenschap toe
        public string Course { get; set; }    // Voeg de Course-eigenschap toe
        public string Level { get; set; }     // Voeg de Level-eigenschap toe
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CompanyUrl { get; set; }
    }

}
