using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Main;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public bool IsLoggedIn { get; set; }

        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using var db = new AppDbContext();

            // Zoek eerst naar de gebruiker in de Users-tabel op basis van de ingevoerde naam
            var user = db.Users
                         .Include(u => u.Student)
                         .Include(u => u.Company)
                         .FirstOrDefault(u => (u.Student != null && u.Student.Name == usernameTextbox.Text) ||
                                              (u.Company != null && u.Company.Name == usernameTextbox.Text));

            if (user != null)
            {
                bool isPasswordValid = false;

                // Controleer het wachtwoord op basis van het type gebruiker
                if (user.IsCompany && user.Company != null && SecureHasher.Verify(passwordBox.Password, user.Company.Password))
                {
                    isPasswordValid = true;
                }
                else if (!user.IsCompany && user.Student != null && SecureHasher.Verify(passwordBox.Password, user.Student.Password))
                {
                    isPasswordValid = true;
                }

                if (isPasswordValid)
                {
                    User.LoggedInUser = user;
                    IsLoggedIn = true;

                    // Navigeren naar de juiste pagina op basis van het type gebruiker
                    if (user.IsCompany)
                    {
                        this.Frame.Navigate(typeof(AccountCompanyPage), user.Company);
                    }
                    else
                    {
                        this.Frame.Navigate(typeof(MainCurioPage), user.Student);
                    }
                    return;
                }
            }

            // Als geen user gevonden is of de wachtwoordverificatie mislukt
            ErrorTextBlock.Text = "Invalid username or password.";
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }
    }
}

