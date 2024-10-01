using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototype_Curio_stagemarkt.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    internal class FavoriteCompanyConfiguration : IEntityTypeConfiguration<FavoriteCompany>
    {
        public void Configure(EntityTypeBuilder<FavoriteCompany> builder)
        {
            builder.HasKey(fc => new { fc.CompanyId, fc.StudentId });

            builder.HasOne(fc => fc.Company)
                .WithMany(c => c.FavoriteCompanies)
                .HasForeignKey(fc => fc.CompanyId);

            builder.HasOne(fc => fc.Student)
                .WithMany(s => s.FavoriteCompanies)
                .HasForeignKey(fc => fc.StudentId);
        }
    }
}
