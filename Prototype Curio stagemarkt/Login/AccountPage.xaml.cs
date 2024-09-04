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
    /// </summary>s
    public sealed partial class AccountPage : Page
    {
        public AccountPage()
        {
            this.InitializeComponent();
            LoadCourses();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Ensure the LoggedInUser is not null
            if (User.LoggedInUser != null)
            {
                // Check if the LoggedInUser is a Student
                if (User.LoggedInUser.StudentId.HasValue)
                {
                    var student = User.LoggedInUser.Student;

                    if (student != null)
                    {
                        studentUsernameTextbox.Text = student.Name;
                        studentPasswordBox.Password = "********"; // Password is masked

                        studentCourseCombobox.SelectedItem = studentCourseCombobox.Items
                            .Cast<ComboBoxItem>()
                            .FirstOrDefault(item => item.Content.ToString() == student.Specialization);
                    }
                    else
                    {
                        ShowError("Logged-in user is not a student.");
                    }
                }
                else
                {
                    ShowError("Logged-in user is not a student.");
                }
            }
        }

        private void LoadCourses()
        {
            using var db = new AppDbContext();
            var courses = db.Courses.Select(c => c.Name).ToList();
            studentCourseCombobox.Items.Clear();
            foreach (var course in courses)
            {
                studentCourseCombobox.Items.Add(new ComboBoxItem { Content = course });
            }
        }

        private void registerNewAccount_Click(object sender, RoutedEventArgs e)
        {
            using var db = new AppDbContext();

            // Validate inputs
            if (string.IsNullOrEmpty(studentUsernameTextbox.Text) ||
                string.IsNullOrEmpty(studentPasswordBox.Password) ||
                studentCourseCombobox.SelectedItem == null)
            {
                ShowError("Please fill all fields.");
                return;
            }

            // Ensure the LoggedInUser is not null and is a Student
            if (User.LoggedInUser is User loggedInStudent)
            {
                // Retrieve the student from the database to ensure it is tracked by the context
                var student = db.Students.FirstOrDefault(s => s.Id == loggedInStudent.Id);

                if (student != null)
                {
                    // Update student data
                    student.Name = studentUsernameTextbox.Text;
                    student.Password = SecureHasher.Hash(studentPasswordBox.Password);
                    student.Specialization = (studentCourseCombobox.SelectedItem as ComboBoxItem)?.Content.ToString();

                    // Save changes to the database
                    db.SaveChanges();

                    // Update the static LoggedInUser object with the changes
                    User.LoggedInUser = User.LoggedInUser;

                    // Navigate to the main page
                    this.Frame.Navigate(typeof(MainCurioPage), student);
                }
                else
                {
                    ShowError("Student not found.");
                }
            }
            else
            {
                ShowError("Logged-in user is not a student.");
            }
        }

        private void ShowError(string message)
        {
            var dialog = new ContentDialog
            {
                Title = "Error",
                Content = message,
                CloseButtonText = "Ok"
            };
            _ = dialog.ShowAsync();
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainCurioPage));
        }
    }
}
