using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototype_Curio_stagemarkt.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    internal class UserConfiguration
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasData(
                new User { Id = 1, Name = "John Doe", UserName = "johndoe", Password = SecureHasher.Hash ("password123"), Education = "Web" },
                new User { Id = 2, Name = "Jane Smith", UserName = "janesmith", Password = SecureHasher.Hash("password456"), Education = "Native" },
                new User { Id = 3, Name = "Nigel Pieter", UserName = "AnsjoNation", Password = SecureHasher.Hash("a"), Education = "Native" },
                new User { Id = 4, Name = "Jorrel Hato", UserName = "Hato", Password = SecureHasher.Hash("h"), Education = "Web" },
                new User { Id = 5, Name = "Luna Smedes", UserName = "lunasmedes", Password = SecureHasher.Hash("n"), Education = "Web" });
        }
    }
}
