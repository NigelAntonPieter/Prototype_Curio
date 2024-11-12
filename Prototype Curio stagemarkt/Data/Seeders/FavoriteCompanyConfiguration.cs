using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using SharedModel.Model;
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
            builder.HasKey(fc => new { fc.StageId, fc.StudentId });

            builder.HasOne(fc => fc.Stage)
                .WithMany(c => c.FavoriteCompanies)
                .HasForeignKey(fc => fc.StageId);

            builder.HasOne(fc => fc.Student)
                .WithMany(s => s.FavoriteCompanies)
                .HasForeignKey(fc => fc.StudentId);
        }
    }
}
