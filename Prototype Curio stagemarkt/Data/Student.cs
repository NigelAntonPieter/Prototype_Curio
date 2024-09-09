using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public string Specialization { get; set; }
        public string ImagePath { get; set; }
        public string ImagePathWithFallBack => ImagePath ?? "/Assets/Profile.png";

        public ICollection<FavoriteCompany> FavoriteCompanies { get; set; } = new List<FavoriteCompany>();
    }
}
