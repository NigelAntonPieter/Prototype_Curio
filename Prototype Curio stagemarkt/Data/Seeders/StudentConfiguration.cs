using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasData(
                 new Student {  Id = 1, Name= "Max", EmailAdress = "student1@example.com", Password = SecureHasher.Hash("wachtwoord"), Specialization = "Native" },
                  new Student { Id = 2, Name = "JJ", EmailAdress = "student2@example.com", Password = SecureHasher.Hash("a"), Specialization = "Native" }
                );
        }
    }
}
