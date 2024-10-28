using Prototype_Curio_stagemarkt.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }

        // Separate foreign keys for Sender
        public int? SenderStudentId { get; set; }
        public int? SenderCompanyId { get; set; }

        // Foreign keys for Receiver
        public int? ReceiverStudentId { get; set; }
        public int? ReceiverCompanyId { get; set; }

        public bool IsRead { get; set; }

        // Navigation properties
        public virtual Student SenderStudent { get; set; }
        public virtual Company SenderCompany { get; set; }
        public virtual Student ReceiverStudent { get; set; }
        public virtual Company ReceiverCompany { get; set; }

        public string SenderName => SenderCompany?.Name ?? SenderStudent?.Name;
        public string ReceiverName => ReceiverCompany?.Name ?? ReceiverStudent?.Name;

        public bool IsSender
        {
            get
            {
                if (User.LoggedInUser.IsCompany)
                {
                    return SenderCompanyId == User.LoggedInUser.CompanyId;
                }
                else
                {
                    return SenderStudentId == User.LoggedInUser.Student.Id;
                }
            }
        }
    }

}
