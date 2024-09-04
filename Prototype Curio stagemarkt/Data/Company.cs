using Microsoft.UI.Xaml.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Street { get; set; }
        public string City { get; set; }    
        public string Description { get; set; }
        public int Level { get; set; }
        public string LearningPath { get; set; }
        public string Specialization { get; set; }
        public string ImagePath { get; set; }
        public string ImagePathWithFallBack => ImagePath ?? "/Assets/images.jpeg";
        public bool IsOpen { get; set; } = true;
        public ICollection<User> Users { get; set; }

    }
}
