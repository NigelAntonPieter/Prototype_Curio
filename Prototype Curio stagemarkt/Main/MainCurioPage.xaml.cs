using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Login;
using Prototype_Curio_stagemarkt.Registreren;
using Prototype_Curio_stagemarkt.Stage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Main
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainCurioPage : Page
    {
        public MainCurioPage()
        {
            this.InitializeComponent();
        }

        private void UpdateRegisterButtonVisibility()
        {
            // Check if the user is logged in
            if (User.LoggedInUser != null)
            {
                RegisterPage.Visibility = Visibility.Collapsed;
                AccountPageButton.Visibility = Visibility.Visible; 
            }
            else
            {
                RegisterPage.Visibility = Visibility.Visible;
                AccountPageButton.Visibility = Visibility.Collapsed;
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            UpdateRegisterButtonVisibility();

            if (User.LoggedInUser != null)
            {
                string userName;

                // Check of de ingelogde gebruiker een student of een bedrijf is
                if (User.LoggedInUser.IsCompany && User.LoggedInUser.Company != null)
                {
                    userName = User.LoggedInUser.Company.Name;
                }
                else if (User.LoggedInUser.Student != null)
                {
                    userName = User.LoggedInUser.Student.Name;
                }
                else
                {
                    userName = "User";
                }

                UserLogin.Text = $"Welcome, {userName}!";
                LoginPage.Content = "Logout";
                LoginPage.Click -= LoginPage_Click;
                LoginPage.Click += LogoutButton_Click;
            }
            else
            {
                UserLogin.Text = "";
                LoginPage.Content = "Login";
                LoginPage.Click -= LogoutButton_Click;
                LoginPage.Click += LoginPage_Click;
            }
        }
        private void RegisterPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }

        private void LoginPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;

            UserLogin.Text = "";
            LoginPage.Content = "Login";
            LoginPage.Click -= LogoutButton_Click; 
            LoginPage.Click += LoginPage_Click;
            this.Frame.Navigate(typeof(MainCurioPage));

        }

        private void searchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchInput = searchTextbox.Text;

            using var db = new AppDbContext();


        }

        private void searchAdresTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchInput = searchAdresTextbox.Text;
            using var db = new AppDbContext();
        }

        private void Bsearch_Click(object sender, RoutedEventArgs e)
        {
            var searchQuery = searchTextbox.Text.Trim().ToLower();
            var searchAdresQuery = searchAdresTextbox.Text.Trim().ToLower();

            using var db = new AppDbContext();

            List<Company> filteredCompanies;

            if (!string.IsNullOrEmpty(searchQuery) && string.IsNullOrEmpty(searchAdresQuery))
            {
                filteredCompanies = db.Companies
                    .Where(c => c.Name.ToLower().Contains(searchQuery))
                    .ToList();
            }
            else if (string.IsNullOrEmpty(searchQuery) && !string.IsNullOrEmpty(searchAdresQuery))
            {
                filteredCompanies = db.Companies
                    .Where(c => c.City.ToLower().Contains(searchAdresQuery))
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(searchQuery) && !string.IsNullOrEmpty(searchAdresQuery))
            {
                filteredCompanies = db.Companies
                    .Where(c => c.Name.ToLower().Contains(searchQuery) && c.City.ToLower().Contains(searchAdresQuery))
                    .ToList();
            }
            else
            {
                filteredCompanies = db.Companies.ToList();
            }

            this.Frame.Navigate(typeof(CompanysList), filteredCompanies);
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }

        private void AccountPageBUtton_Click(object sender, RoutedEventArgs e)
        {
            if (User.LoggedInUser != null)
            {
                if (User.LoggedInUser.IsCompany)
                {
                    // Navigeer naar AccountCompanyPage en stuur het bedrijf mee als parameter
                    this.Frame.Navigate(typeof(AccountCompanyPage), User.LoggedInUser);
                }
                else
                {
                    // Navigeer naar AccountPage en stuur de student mee als parameter
                    this.Frame.Navigate(typeof(AccountPage), User.LoggedInUser);
                }
            }
        }
    }
}
