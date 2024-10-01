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
    public class LearningPathConfigurationv : IEntityTypeConfiguration<LearningPath>
    {
        public void Configure(EntityTypeBuilder<LearningPath> builder)
        {
            builder.HasData(
                new LearningPath { Id = 1, Name = "BOL" },
                new LearningPath { Id = 2, Name = "BBL" }
                );
        }
    }
}
