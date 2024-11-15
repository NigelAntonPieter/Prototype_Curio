using Microsoft.EntityFrameworkCore;
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
using SharedModel.Model;
using SharedModel.Data;
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

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            User.LoggedInUser = null;
            this.Frame.Navigate(typeof(WelcomePage));
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
            }
            else
            {
                UserLogin.Text = "";
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



        private void searchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchInput = searchTextbox.Text;

            using var db = new CurioContext();
        }

        private void searchAdresTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchInput = searchAdresTextbox.Text;
            using var db = new CurioContext();
        }

        private void Bsearch_Click(object sender, RoutedEventArgs e)
        {
            var searchQuery = searchTextbox.Text.Trim();
            var searchAdresQuery = searchAdresTextbox.Text.Trim();

            using var db = new CurioContext();

            List<StageMarkt> filteredCompanies;

            var stages = db.Stages.AsEnumerable(); 

            if (!string.IsNullOrEmpty(searchQuery))
            {
                stages = stages.Where(c => c.Name.ToLower().Contains(searchQuery.ToLower()));
            }

            if (!string.IsNullOrEmpty(searchAdresQuery))
            {
                stages = stages.Where(c => c.City.ToLower().Contains(searchAdresQuery.ToLower()));
            }

            filteredCompanies = stages.ToList(); 

            if (User.LoggedInUser?.Student != null)
            {
                this.Frame.Navigate(typeof(APiList), new Tuple<Student, List<StageMarkt>>(User.LoggedInUser.Student, filteredCompanies));
            }
        }


        private void AccountPageBUtton_Click(object sender, RoutedEventArgs e)
        {
            if (User.LoggedInUser != null)
            {
                if (User.LoggedInUser.IsCompany)
                {
                    this.Frame.Navigate(typeof(AccountCompanyPage), User.LoggedInUser.CompanyId);
                }
                else
                {
                    this.Frame.Navigate(typeof(AccountPage), User.LoggedInUser);
                }
            }
        }

        private void Bfakesearch_Click(object sender, RoutedEventArgs e)
        {
            var searchQuery = searchTextbox.Text.Trim();
            var searchAdresQuery = searchAdresTextbox.Text.Trim();

            using var db = new CurioContext();

            List<Company> filteredCompanies;

            var companies = db.Companies.AsEnumerable(); 

            if (!string.IsNullOrEmpty(searchQuery))
            {
                companies = companies.Where(c => c.Name.ToLower().Contains(searchQuery.ToLower()));
            }

            if (!string.IsNullOrEmpty(searchAdresQuery))
            {
                companies = companies.Where(c => c.City.ToLower().Contains(searchAdresQuery.ToLower()));
            }

            filteredCompanies = companies.ToList(); 

            if (User.LoggedInUser?.Student != null)
            {
                this.Frame.Navigate(typeof(CompanyList), (filteredCompanies, User.LoggedInUser.Student));
            }
        }
    }
}
