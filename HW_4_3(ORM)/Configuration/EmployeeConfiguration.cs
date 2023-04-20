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

            builder.HasData(new[]
            {
                    new Employee
                    {
                        EmployeeId = 1,
                        FirstName = "Josh",
                        LastName = "Pipka",
                        HiredData = new DateTime(2009, 11, 25),
                        DateOfBirht = new DateTime(1560, 02, 03),
                        OfficeId = 1,
                        TitleId = 1,
                    },                    
                    new Employee
                    {
                        EmployeeId = 2,
                        FirstName = "Vasan",
                        LastName = "Zapal",
                        HiredData = new DateTime(1850, 12, 12),
                        DateOfBirht = new DateTime(1450, 06, 05),
                        OfficeId = 2,
                        TitleId = 2,
                    },                    
                    new Employee
                    {
                        EmployeeId = 3,
                        FirstName = "Nina",
                        LastName = "Ponos",
                        HiredData = new DateTime(2000, 07, 07),
                        DateOfBirht = new DateTime(0001, 01, 01),
                        OfficeId = 3,
                        TitleId = 3,
                    },                    
                    new Employee
                    {
                        EmployeeId = 4,
                        FirstName = "Maksim",
                        LastName = "Katz",
                        HiredData = new DateTime(2020, 07, 07),
                        DateOfBirht = new DateTime(0002, 01, 01),
                        OfficeId = 4,
                        TitleId = 4,
                    },                    
                    new Employee
                    {
                        EmployeeId = 5,
                        FirstName = "Valera",
                        LastName = "Ponosov",
                        HiredData = new DateTime(2003, 07, 07),
                        DateOfBirht = new DateTime(1476, 01, 01),
                        OfficeId = 5,
                        TitleId = 5,
                    },
            });
        }
    }
}
