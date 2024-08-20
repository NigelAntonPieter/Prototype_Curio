using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    internal class User
    {

        public static User LoggedInUser { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Education { get; set; }
        public ICollection<Company> Companys { get; set; }

        static User CurrentUser;
    }
}
