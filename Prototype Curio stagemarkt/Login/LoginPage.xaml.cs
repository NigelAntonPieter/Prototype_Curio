using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Prototype_Curio_stagemarkt.AdminMap;
using Prototype_Curio_stagemarkt.Data;
using SharedModel;
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
            usernameTextbox.KeyUp += UsernameTextbox_KeyUp;
            passwordBox.KeyUp += PasswordBox_KeyUp;
        }

        private void UsernameTextbox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                AttemptLogin();
            }
        }

        private void PasswordBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                AttemptLogin();
            }
        }

        private void AttemptLogin()
        {
            using var db = new AppDbContext();

            var user = db.Users
                         .Include(u => u.Student)
                         .Include(u => u.Company)
                         .Include(u => u.Admin)
                         .Include(u => u.Interschip)
                         .FirstOrDefault(u => (u.Student.Name != null && u.Student.Name == usernameTextbox.Text) ||
                                              (u.Company.Name != null && u.Company.Name == usernameTextbox.Text) ||
                                              (u.Interschip.Name != null && u.Interschip.Name == usernameTextbox.Text) ||
                                              (u.Admin.Name != null && u.Admin.Name == usernameTextbox.Text));

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

        private bool VerifyPassword(User user)
        {
            if (user.IsCompany)
            {
                return user.Company != null && SecureHasher.Verify(passwordBox.Password, user.Company.Password);
            }
            else if (user.Student != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Student.Password);
            }
            else if (user.Admin != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Admin.Password);
            }
            else if (user.Interschip != null)
            {
                return SecureHasher.Verify(passwordBox.Password, user.Interschip.Password);
            }

            return false;
        }

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

        private void DisplayErrorMessage()
        {
            ErrorTextBlock.Text = "Invalid username or password.";
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WelcomePage));
        }
    }
}
