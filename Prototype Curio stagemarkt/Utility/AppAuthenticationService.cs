using Prototype_Curio_stagemarkt.Data;
using Prototype_Curio_stagemarkt.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Utility
{
    internal class AppAuthenticationService
    {
        public bool Authenticate(string name, string password)
        {
            using (var db = new AppDbContext())
            {
                var student = db.Students.SingleOrDefault(u => u.Name == name);
                if (student != null)
                {
                    bool isValidPassword = SecureHasher.Verify(password, student.Password);
                    if (isValidPassword)
                    {
                        // Als de gebruiker een student is, stel User.LoggedInUser in als een Student
                        if (!User.LoggedInUser.IsCompany)
                        {
                            User.LoggedInUser = User.LoggedInUser;
                        }
                    }
                    return isValidPassword;
                }

                return false;
            }
        }
    }
}
