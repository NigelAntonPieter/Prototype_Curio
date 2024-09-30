using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Models
{
    public class LearningPath
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigeerbare Eigenschap voor de bedrijven die bij deze leerweg horen
        public ICollection<Company> Companies { get; set; }
    }
}
