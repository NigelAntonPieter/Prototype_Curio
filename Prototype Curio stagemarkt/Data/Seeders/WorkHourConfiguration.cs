using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedModel.Model;
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
    new WorkHour { Id = 2, StudentId = 2, Date = DateTime.Today.AddDays(-1), HoursWorked = 4, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 3, StudentId = 1, Date = DateTime.Today.AddDays(-2), HoursWorked = 5, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 4, StudentId = 3, Date = DateTime.Today.AddDays(-3), HoursWorked = 7, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 5, StudentId = 4, Date = DateTime.Today.AddDays(-4), HoursWorked = 6, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 6, StudentId = 5, Date = DateTime.Today.AddDays(-5), HoursWorked = 8, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 7, StudentId = 2, Date = DateTime.Today.AddDays(-6), HoursWorked = 4, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 8, StudentId = 3, Date = DateTime.Today.AddDays(-7), HoursWorked = 5, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 9, StudentId = 4, Date = DateTime.Today.AddDays(-8), HoursWorked = 3, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 10, StudentId = 5, Date = DateTime.Today.AddDays(-9), HoursWorked = 2, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 11, StudentId = 6, Date = DateTime.Today.AddDays(-10), HoursWorked = 7, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 12, StudentId = 7, Date = DateTime.Today.AddDays(-11), HoursWorked = 4, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 13, StudentId = 8, Date = DateTime.Today.AddDays(-10), HoursWorked = 6, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 14, StudentId = 9, Date = DateTime.Today.AddDays(-13), HoursWorked = 5, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 15, StudentId = 10, Date = DateTime.Today.AddDays(-14), HoursWorked = 3, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 16, StudentId = 1, Date = DateTime.Today.AddDays(-15), HoursWorked = 6, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 17, StudentId = 2, Date = DateTime.Today.AddDays(-16), HoursWorked = 8, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 18, StudentId = 3, Date = DateTime.Today.AddDays(-7), HoursWorked = 5, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 19, StudentId = 4, Date = DateTime.Today.AddDays(-18), HoursWorked = 7, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 20, StudentId = 5, Date = DateTime.Today.AddDays(-19), HoursWorked = 4, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 21, StudentId = 6, Date = DateTime.Today.AddDays(-10), HoursWorked = 6, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 22, StudentId = 7, Date = DateTime.Today.AddDays(-21), HoursWorked = 3, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 23, StudentId = 8, Date = DateTime.Today.AddDays(-22), HoursWorked = 5, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 24, StudentId = 9, Date = DateTime.Today.AddDays(-3), HoursWorked = 8, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 25, StudentId = 10, Date = DateTime.Today.AddDays(-24), HoursWorked = 4, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 26, StudentId = 1, Date = DateTime.Today.AddDays(-25), HoursWorked = 7, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 27, StudentId = 2, Date = DateTime.Today.AddDays(-26), HoursWorked = 3, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 28, StudentId = 3, Date = DateTime.Today.AddDays(-27), HoursWorked = 5, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 29, StudentId = 4, Date = DateTime.Today.AddDays(-8), HoursWorked = 2, Status = WorkHoursStatus.Unapproved },
    new WorkHour { Id = 30, StudentId = 5, Date = DateTime.Today.AddDays(-19), HoursWorked = 6, Status = WorkHoursStatus.Approved },
    new WorkHour { Id = 31, StudentId = 6, Date = DateTime.Today.AddDays(-30), HoursWorked = 8, Status = WorkHoursStatus.InReview },
    new WorkHour { Id = 32, StudentId = 7, Date = DateTime.Today.AddDays(-1), HoursWorked = 4, Status = WorkHoursStatus.Approved }
);

        }
    }
}
