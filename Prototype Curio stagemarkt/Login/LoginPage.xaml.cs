using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Prototype_Curio_stagemarkt.Admin;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Main;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Linq;

namespace Prototype_Curio_stagemarkt.Login
{
    public sealed partial class LoginPage : Page
    {
        public bool IsLoggedIn { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
            // Voeg key event handlers toe voor de tekstvakken
            usernameTextbox.KeyUp += UsernameTextbox_KeyUp;
            passwordBox.KeyUp += PasswordBox_KeyUp;
        }

        // Key event handler for username textbox
        private void UsernameTextbox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                AttemptLogin();
            }
        }

        // Key event handler for password box
        private void PasswordBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                AttemptLogin();
            }
        }

        // Attempt login based on the provided credentials
        private void AttemptLogin()
        {
            using var db = new AppDbContext();

            var user = db.Users
                         .Include(u => u.Student)
                         .Include(u => u.Company)
                         .Include(u => u.Admin)
                         .Include(u => u.Interschip)
                         .FirstOrDefault(u => (u.Student != null && u.Student.Name == usernameTextbox.Text) ||
                                              (u.Company != null && u.Company.Name == usernameTextbox.Text) ||
                                              (u.Interschip != null && u.Interschip.Name == usernameTextbox.Text) ||
                                              (u.Admin != null && u.Admin.Name == usernameTextbox.Text));

            if (user != null && VerifyPassword(user))
            {
                user.LastLogin = DateTime.Now;
                db.SaveChanges();

                User.LoggedInUser = user;
                IsLoggedIn = true;

                NavigateToPage(user);
            }
            else
            {
                DisplayErrorMessage();
            }
        }

        // Verify password for the user
        private bool VerifyPassword(User user)
        {
            if (user.IsCompany && user.Company != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Company.Password);
            }
            if (!user.IsCompany && user.Student != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Student.Password);
            }
            if (!user.IsCompany && user.Admin != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Admin.Password);
            }
            if (!user.IsCompany && user.Interschip != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Interschip.Password);
            }

            return false;
        }

        // Navigate to the appropriate page based on the user role
        private void NavigateToPage(User user)
        {
            if (user.IsCompany)
            {
                Frame.Navigate(typeof(AccountCompanyPage), user.CompanyId);
            }
            else if (user.Student != null)
            {
                Frame.Navigate(typeof(MainCurioPage), user.Student);
            }
            else if (user.Admin != null)
            {
                Frame.Navigate(typeof(AdminPage), user.Admin.Id);
            }
            else if (user.Interschip != null)
            {
                Frame.Navigate(typeof(AccountTeacherPage), user.Interschip.Id);
            }
        }

        // Display an error message if the login attempt fails
        private void DisplayErrorMessage()
        {
            ErrorTextBlock.Text = "Invalid username or password.";
        }

        // Event handler for the logo button
        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WelcomePage));
        }
    }
}
