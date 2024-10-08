using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototype_Curio_stagemarkt.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data.Seeders
{
    class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            // Configuring sender relationships
            builder.HasOne(m => m.SenderStudent)
                   .WithMany()
                   .HasForeignKey(m => m.SenderStudentId) // Using separate foreign key
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Message_SenderStudent");

            builder.HasOne(m => m.SenderCompany)
                   .WithMany()
                   .HasForeignKey(m => m.SenderCompanyId) // Using separate foreign key
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Message_SenderCompany");

            // Configuring receiver relationships
            builder.HasOne(m => m.ReceiverStudent)
                   .WithMany()
                   .HasForeignKey(m =>m.ReceiverStudentId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Message_ReceiverStudent");

            builder.HasOne(m => m.ReceiverCompany)
                   .WithMany()
                   .HasForeignKey(m => m.ReceiverCompanyId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Message_ReceiverCompany");
        }

    }
}
