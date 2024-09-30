using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    internal class AdminConfiguration : IEntityTypeConfiguration<AdminClass>
    {
        public void Configure(EntityTypeBuilder<AdminClass> builder)
        {

            builder.HasData(
                 new AdminClass { Id = 1, Name = "Fedde",  Password = SecureHasher.Hash("wachtwoord") }
                );
        }
    }
}
