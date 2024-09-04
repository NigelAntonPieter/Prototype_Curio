using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{

    public class User
    {
        public static User LoggedInUser { get; set; }
        public int Id { get; set; }
        public bool IsCompany { get; set; } // True for Company, False for Student

        public int? CompanyId { get; set; } 
        public Company Company { get; set; }

        public int? StudentId { get; set; }
        public Student Student{ get; set; }
    }
}
