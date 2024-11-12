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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasOne(u => u.Company)
                   .WithMany(c => c.Users)
                   .HasForeignKey(u => u.CompanyId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.Student)
                   .WithMany()
                   .HasForeignKey(u => u.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Admin)
                .WithMany()
                .HasForeignKey(a => a.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Interschip)
                .WithMany()
                .HasForeignKey(a => a.IntershipTeacherId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new User { Id = 1, IsCompany = false, StudentId = 1 },
                new User { Id = 2, IsCompany = false, StudentId = 2 },
                new User { Id = 3, IsCompany = false, StudentId = 3 },
                new User { Id = 4, IsCompany = false, StudentId = 4 },
                new User { Id = 5, IsCompany = false, StudentId = 5 },
                new User { Id = 6, IsCompany = false, StudentId = 6 },
                new User { Id = 7, IsCompany = false, StudentId = 7 },
                new User { Id = 8, IsCompany = false, StudentId = 8 },
                new User { Id = 9, IsCompany = false, StudentId = 9 },
                new User { Id = 10, IsCompany = false, StudentId = 10 },
                new User { Id = 11, IsCompany = false, IntershipTeacherId = 1 },
                new User { Id = 12, IsCompany = false, IntershipTeacherId = 2 },
                new User { Id = 13, IsCompany = false, AdminId = 1 },
                new User { Id = 14, IsCompany = true, CompanyId = 1 },
                new User { Id = 15, IsCompany = true, CompanyId = 2 },
                new User { Id = 16, IsCompany = true, CompanyId = 3 },
                new User { Id = 17, IsCompany = true, CompanyId = 4 },
                new User { Id = 18, IsCompany = true, CompanyId = 5 },
                new User { Id = 19, IsCompany = true, CompanyId = 6 });
        }
    }
}
