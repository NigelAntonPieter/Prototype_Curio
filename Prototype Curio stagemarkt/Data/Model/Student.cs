using Prototype_Curio_stagemarkt.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Specialization { get; set; }
        public string ImagePath { get; set; }
        public string ImagePathWithFallBack => ImagePath ?? "/Assets/Profile.png";

        public int? InternshipTeacherId { get; set; }
        public InternschipTeacher InternschipTeacher { get; set; }

        public ICollection<FavoriteCompany> FavoriteCompanies { get; set; } = new List<FavoriteCompany>();
        public ICollection<WorkHour> workHours { get; set; } = new List<WorkHour>();
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();

    }
}
