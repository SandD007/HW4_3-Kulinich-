using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HW43
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
               .ToTable("Employe");

            builder
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder 
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
