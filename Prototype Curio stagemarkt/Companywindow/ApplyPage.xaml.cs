using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SharedModel.Model;
using SharedModel.Data;
using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.Companywindow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ApplyPage : Page
    {
        private StorageFile copiedFile;
        public string CvFilePath { get; private set; }
        private int selectedCompanyId;

        public ApplyPage()
        {
            this.InitializeComponent();
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is (Company company, Student student, int companyId))
            {
                selectedCompanyId = companyId;

                // Vul de velden in met gegevens van de student, indien aanwezig
                if (User.LoggedInUser != null && User.LoggedInUser.Student != null)
                {
                    var loggedInStudent = User.LoggedInUser.Student;
                    nameTextbox.Text = loggedInStudent.Name;
                    emailTextbox.Text = loggedInStudent.EmailAddress;
                }
            }
        }


        private bool ValidateApplicationInputs()
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text) ||
                string.IsNullOrWhiteSpace(emailTextbox.Text) ||
                string.IsNullOrWhiteSpace(descriptionTextbox.Text))
            {
                return false;
            }
            return true;
        }

        private async void saveApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateApplicationInputs())
            {
                using (var db = new CurioContext())
                {
                    var companyExists = db.Companies.Any(c => c.Id == selectedCompanyId);
                    if (!companyExists)
                    {
                        return;
                    }

                    var currentStudent = User.LoggedInUser.Student;
                    var newApplication = new SharedModel.Model.Application
                    {
                        StudentId = currentStudent.Id,
                        CompanyId = selectedCompanyId,
                        Name = nameTextbox.Text,
                        Email = emailTextbox.Text,
                        Motivation = descriptionTextbox.Text,
                        CvFilePath = CvFilePath
                    };

                    db.Applications.Add(newApplication);
                    await db.SaveChangesAsync();

                    this.Frame.Navigate(typeof(MainCurioPage));
                }
            }
            else
            {
                await noFileDialog.ShowAsync();
            }
        }

        private async void cvUploadButton_Click(object sender, RoutedEventArgs e)
        {
            await SelectAndCopyFileAsync();
        }

        private async Task SelectAndCopyFileAsync()
        {
            var fileopenPicker = new FileOpenPicker
            {
                FileTypeFilter = { ".pdf" }
            };

            nint windowHandle = WindowNative.GetWindowHandle(App.m_window);
            InitializeWithWindow.Initialize(fileopenPicker, windowHandle);

            var file = await fileopenPicker.PickSingleFileAsync();

            if (file != null)
            {
                var localFolder = ApplicationData.Current.LocalFolder;

                var fileExtension = file.FileType;

                var currentTime = DateTime.Now;
                var renamedFileName = $"{currentTime.ToFileTime()}{fileExtension}";

                copiedFile = await file.CopyAsync(localFolder, renamedFileName);
                CvFilePath = copiedFile.Path;
            }
        }

        private void noFileDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }
    }
}
