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
    public class WorkHourConfiguration : IEntityTypeConfiguration<WorkHour>
    {
        public void Configure(EntityTypeBuilder<WorkHour> builder)
        {
            builder.HasOne(wh => wh.Student)
                    .WithMany(s => s.workHours)
                    .HasForeignKey(wh => wh.StudentId);


            builder.HasData(
                new WorkHour { Id = 1, StudentId = 1, Date = DateTime.Today, HoursWorked = 8, Status = WorkHoursStatus.InReview },
                new WorkHour { Id = 2, StudentId = 2, Date = DateTime.Today.AddDays(-1), HoursWorked = 4, Status = WorkHoursStatus.InReview }
            );
        }
    }
}
