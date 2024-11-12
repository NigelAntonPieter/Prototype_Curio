using Microsoft.EntityFrameworkCore;
using SharedModel.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    internal class CurioContext : AppDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql(
                ConfigurationManager.ConnectionStrings["curiostagemarkt"].ConnectionString,
                ServerVersion.Parse("5.7.33-winx64"));
        }
    }
}
