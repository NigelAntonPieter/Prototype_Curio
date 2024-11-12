using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedModel.Model;
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
            builder.HasOne(s => s.InternschipTeacher)
                   .WithMany()
                   .HasForeignKey(s => s.InternshipTeacherId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                 new Student { Id = 1, Name = "Max", EmailAddress = "student1@example.com", Password = SecureHasher.Hash("wachtwoord"), Specialization = "Native", InternshipTeacherId = 1 },
                  new Student { Id = 2, Name = "JJ", EmailAddress = "student2@example.com", Password = SecureHasher.Hash("a"), Specialization = "Web", InternshipTeacherId = 2 },
                  new Student { Id = 3, Name = "Krijn", EmailAddress = "student1@example.com", Password = SecureHasher.Hash("wachtwoord"), Specialization = "FrontEnd", InternshipTeacherId = 1 },
                  new Student { Id = 4, Name = "Luna", EmailAddress = "student2@example.com", Password = SecureHasher.Hash("a"), Specialization = "Native", InternshipTeacherId = 2 },
                  new Student { Id = 5, Name = "Wiardi", EmailAddress = "student1@example.com", Password = SecureHasher.Hash("wachtwoord"), Specialization = "Web", InternshipTeacherId = 1 },
                  new Student { Id = 6, Name = "Nigel", EmailAddress = "student2@example.com", Password = SecureHasher.Hash("n"), Specialization = "Native", InternshipTeacherId = 2 },
                  new Student { Id = 7, Name = "Kelvin", EmailAddress = "student1@example.com", Password = SecureHasher.Hash("wachtwoord"), Specialization = "Native", InternshipTeacherId = 1 },
                  new Student { Id = 8, Name = "Jonathan", EmailAddress = "student2@example.com", Password = SecureHasher.Hash("a"), Specialization = "Web", InternshipTeacherId = 1 },
                  new Student { Id = 9, Name = "Brent", EmailAddress = "student1@example.com", Password = SecureHasher.Hash("wachtwoord"), Specialization = "Native", InternshipTeacherId = 1 },
                  new Student { Id = 10, Name = "Simon", EmailAddress = "student2@example.com", Password = SecureHasher.Hash("a"), Specialization = "Native", InternshipTeacherId = 2 }
                );
        }
    }
}
