using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    internal class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasData(
                new Level { Id = 1, GradeLevel = 2 },
                new Level { Id = 2, GradeLevel = 3 },
                new Level { Id = 3, GradeLevel = 4 });
        }
    }
}
