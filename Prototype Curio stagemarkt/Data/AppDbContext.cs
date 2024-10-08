using Microsoft.EntityFrameworkCore;
using Prototype_Curio_stagemarkt.Data.Model;
using Prototype_Curio_stagemarkt.Data.Models;
using Prototype_Curio_stagemarkt.Data.Seeders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<LearningPath> LearningPaths { get; set; }
        public DbSet<FavoriteCompany> FavoriteCompanies { get; set; }
        public DbSet<InternschipTeacher> InternschipTeachers { get; set; }
        public DbSet<WorkHour> WorkHours { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Message> Messages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql(
               ConfigurationManager.ConnectionStrings["CurioStagemarkt"].ConnectionString,
               ServerVersion.Parse("5.7.33-winx64"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new LearningPathConfigurationv());
            modelBuilder.ApplyConfiguration(new LevelConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new InternshipTeacherConfiguration());
            modelBuilder.ApplyConfiguration(new WorkHourConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
        }
    }
}
