using Microsoft.EntityFrameworkCore;
using Prototype_Curio_stagemarkt.Data.Seeders;
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
        public DbSet<Company> Companies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LearningPath> LearningPaths { get; set; }
        public DbSet<FavoriteCompany> FavoriteCompanies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql(
               ConfigurationManager.ConnectionStrings["CurioStagemarkt"].ConnectionString,
               ServerVersion.Parse("5.7.33-winx64"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasOne(u => u.Company)
                 .WithMany(c => c.Users)
                 .HasForeignKey(u => u.CompanyId)
                 .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Student)
                .WithMany()
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Company>()
            .HasOne(c => c.LearningPath)
            .WithMany(lp => lp.Companies)
            .HasForeignKey(c => c.LearningPathId);

            modelBuilder.Entity<FavoriteCompany>()
                .HasKey(fc => new { fc.CompanyId, fc.StudentId });

            modelBuilder.Entity<FavoriteCompany>()
                .HasOne(fc => fc.Company)
                .WithMany(c => c.FavoriteCompanies)
                .HasForeignKey(fc => fc.CompanyId);

            modelBuilder.Entity<FavoriteCompany>()
                .HasOne(fc => fc.Student)
                .WithMany(s => s.FavoriteCompanies)
                .HasForeignKey(fc => fc.StudentId);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new LearningPathConfigurationv());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
    }
}
