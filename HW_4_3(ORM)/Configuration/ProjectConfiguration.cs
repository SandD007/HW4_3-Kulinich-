using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW43
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
               .ToTable("Project");
           
            builder
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.ProjectId)
                .IsRequired();

            builder
                .Property(e => e.ClientId)
                .IsRequired();

            builder.HasData(new[]
            {
                new Project
                {
                    ProjectId = 1,
                    Name = "Fanta",
                    Budget = 12000,
                    StartedData = new DateTime(2020, 02, 02),
                    ClientId = 1,
                },                
                new Project
                {
                    ProjectId = 2,
                    Name = "CSGO",
                    Budget = 24000,
                    StartedData = new DateTime(2021, 01, 01),
                    ClientId = 2,
                },                
                new Project
                {
                    ProjectId = 3,
                    Name = "WOW",
                    Budget = 850000,
                    StartedData = new DateTime(2023, 03, 04),
                    ClientId = 3,
                },                
                new Project
                {
                    ProjectId = 4,
                    Name = "Wurm",
                    Budget = 8520000,
                    StartedData = new DateTime(2019, 03, 04),
                    ClientId = 4,
                },                
                new Project
                {
                    ProjectId = 5,
                    Name = "RDR2",
                    Budget = 8150000,
                    StartedData = new DateTime(2017, 03, 04),
                    ClientId = 5,
                },
            });
        }
    }
}
