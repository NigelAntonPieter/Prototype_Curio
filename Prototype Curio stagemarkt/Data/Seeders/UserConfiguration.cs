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

            builder.HasData(
                 new User { Id = 1,  IsCompany = true, CompanyId = 1 },
                    new User { Id = 2, IsCompany = false, StudentId = 1 }
                );
        }
    }
}
