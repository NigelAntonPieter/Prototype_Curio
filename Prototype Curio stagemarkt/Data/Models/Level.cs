using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Models
{
    public class Level
    {
        public int Id { get; set; }
        public int GradeLevel { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
