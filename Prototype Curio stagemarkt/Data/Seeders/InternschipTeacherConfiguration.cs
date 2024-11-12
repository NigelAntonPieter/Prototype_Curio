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
    public class InternshipTeacherConfiguration : IEntityTypeConfiguration<InternschipTeacher>
    {
        public void Configure(EntityTypeBuilder<InternschipTeacher> builder)
        {

            builder.HasData(
                 new InternschipTeacher { Id = 1, Name = "Laurens", Password = SecureHasher.Hash("l") },
                  new InternschipTeacher { Id = 2, Name = "Kiki", Password = SecureHasher.Hash("k") }
                );
        }
    }
}
