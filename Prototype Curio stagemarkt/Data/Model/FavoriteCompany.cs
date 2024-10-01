using Prototype_Curio_stagemarkt.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Models
{
    public class FavoriteCompany
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
