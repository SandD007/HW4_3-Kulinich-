using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW43
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
               .ToTable("EmployeProject");

            builder.HasData(new[]
            {
                new EmployeeProject
                {
                    EmployeeProjectId = 1,
                    Rate = 2500,
                    StartedData = new DateTime(2020, 01, 06),
                    EmployeeId = 1,
                    ProjectId = 1,
                },                
                new EmployeeProject
                {
                    EmployeeProjectId = 2,
                    Rate = 6200,
                    StartedData = new DateTime(2019, 02, 03),
                    EmployeeId = 2,
                    ProjectId = 2,
                },               
                new EmployeeProject
                {
                    EmployeeProjectId = 3,
                    Rate = 7630,
                    StartedData = new DateTime(2021, 06, 01),
                    EmployeeId = 3,
                    ProjectId = 3,
                },                
                new EmployeeProject
                {
                    EmployeeProjectId = 4,
                    Rate = 8463,
                    StartedData = new DateTime(2021, 06, 01),
                    EmployeeId = 4,
                    ProjectId = 4,
                },                
                new EmployeeProject
                {
                    EmployeeProjectId = 5,
                    Rate = 84320,
                    StartedData = new DateTime(2021, 06, 01),
                    EmployeeId = 5,
                    ProjectId = 5,
                },
            });
        }
    }
}
