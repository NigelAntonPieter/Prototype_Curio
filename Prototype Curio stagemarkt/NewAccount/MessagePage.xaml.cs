using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Prototype_Curio_stagemarkt.Data.Model;
using System.Collections.ObjectModel;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Prototype_Curio_stagemarkt.NewAccount
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MesagePage : Page
    {
        private int _studentId;
        private int _companyId;
        public ObservableCollection<Message> Messages { get; set; }
        public MesagePage()
        {
            this.InitializeComponent();
            Messages = new ObservableCollection<Message>();
            this.DataContext = this;
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var (studentId, companyId) = ((int, int))e.Parameter;
            var messages = GetMessagesForChat(studentId, companyId);
            MessagesListView.ItemsSource = messages;
        }

        public List<Message> GetMessagesForChat(int studentId, int companyId)
        {
            using var db = new AppDbContext();
            var messages = db.Messages
                .Where(m => (m.SenderStudentId == studentId && m.ReceiverCompanyId == companyId) ||
                            (m.SenderCompanyId == companyId && m.ReceiverStudentId == studentId))
                .OrderBy(m => m.SentAt) 
                .ToList();

            return messages;
        }


        private async void LoadMessages()
        {
            using (var db = new AppDbContext())
            {
                List<Message> messages;

                if (User.LoggedInUser.IsCompany) 
                {
                    messages = await db.Messages
                        .Where(m => m.SenderCompanyId == User.LoggedInUser.CompanyId && m.ReceiverStudentId == _studentId)
                        .Include(m => m.SenderCompany)
                        .Include(m => m.SenderStudent)
                        .OrderBy(m => m.SentAt)
                        .ToListAsync();
                }
                else 
                {
                    messages = await db.Messages
                        .Where(m => m.SenderStudentId == User.LoggedInUser.Student.Id && m.ReceiverCompanyId == _companyId)
                        .Include(m => m.SenderCompany)
                        .Include(m => m.SenderStudent)
                        .OrderBy(m => m.SentAt)
                        .ToListAsync();
                }

                Messages.Clear();
                foreach (var message in messages)
                {
                    Messages.Add(message);
                }
            }
        }



        private async void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NewMessageTextBox.Text))
            {
                // Check if the receiver exists based on whether the user is a company or a student
                bool receiverExists;

                if (User.LoggedInUser.IsCompany)
                {
                    // Check if the receiver student exists
                    receiverExists = await DoesStudentExist(_studentId);
                }
                else
                {
                    // Here, you might want to check if the company exists instead if the user is a student
                    receiverExists = await DoesCompanyExist(_companyId);
                }

                if (!receiverExists)
                {
                    // Handle the case where the receiver does not exist
                    Debug.WriteLine($"Receiver does not exist. StudentId: {_studentId}, CompanyId: {_companyId}");
                    return; // Exit the method if the receiver is not found
                }

                var newMessage = new Message
                {
                    Content = NewMessageTextBox.Text,
                    SentAt = DateTime.Now,
                    IsRead = false
                };

                if (User.LoggedInUser.IsCompany)
                {
                    newMessage.SenderCompanyId = User.LoggedInUser.CompanyId;
                    newMessage.ReceiverStudentId = _studentId;
                    newMessage.SenderStudentId = null;
                }
                else
                {
                    newMessage.SenderStudentId = User.LoggedInUser.Student.Id;
                    newMessage.ReceiverCompanyId = _companyId;
                    newMessage.SenderCompanyId = null;
                }

                await SaveMessage(newMessage);
                Messages.Add(newMessage);
                NewMessageTextBox.Text = string.Empty;
            }
        }


        private async Task SaveMessage(Message message)
        {
            using (var db = new AppDbContext())
            {
                db.Messages.Add(message);
                await db.SaveChangesAsync();
            }
        }

        private async Task<bool> DoesStudentExist(int studentId)
        {
            using (var db = new AppDbContext())
            {
                return await db.Students.AnyAsync(s => s.Id == studentId);
            }
        }
        private async Task<bool> DoesCompanyExist(int companyId)
        {
            using (var db = new AppDbContext())
            {
                return await db.Companies.AnyAsync(c => c.Id == companyId);
            }
        }
    }
}
