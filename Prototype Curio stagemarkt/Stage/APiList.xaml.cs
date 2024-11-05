using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Stage
{
    public sealed partial class APiList : Page
    {
        private const string ApiUrl = "https://localhost:7249/api/Stages"; // Change to your actual API URL

        public APiList()
        {
            this.InitializeComponent();
            LoadStages();
        }

        private async void LoadStages()
        {
            try
            {
                var stages = await GetStagesAsync();
                if (stages != null && stages.Count > 0)
                {
                    StagesListView.ItemsSource = stages;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No stages found.");
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle errors here (e.g., show a message to the user)
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

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
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
    }

}
