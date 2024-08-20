using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    internal class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql(
               ConfigurationManager.ConnectionStrings["CurioStagemarkt"].ConnectionString,
               ServerVersion.Parse("5.7.33-winx64"));
        }
    }
}
