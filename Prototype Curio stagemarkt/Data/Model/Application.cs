using Prototype_Curio_stagemarkt.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Motivation { get; set; }
        public int StudentId { get; set; }
        public int CompanyId { get; set; }
        public string CvFilePath { get; set; }
        public DateTime AppliedOn { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Pending";

        public Student Student { get; set; }
        public Company Company { get; set; }
    }
}
