using Prototype_Curio_stagemarkt.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Models
{
    public class WorkHour
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public int HoursWorked { get; set; }
        public WorkHoursStatus Status { get; set; }
        public string Reason { get; set; }
    }

    public enum WorkHoursStatus
    {
        InReview,
        Approved,
        Rejected
    }
}
