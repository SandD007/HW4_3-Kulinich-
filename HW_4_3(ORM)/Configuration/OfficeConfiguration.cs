using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW43
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
               .ToTable("Office");
           
            builder
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);          
            
            builder
                .Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasData(new[]
            {
                new Office
                {
                    OfficeID = 1,
                    Title = "Some Title",
                    Location = "USA",
                },                
                new Office
                {
                    OfficeID = 2,
                    Title = "Some Title2",
                    Location = "Canada",
                },                
                new Office
                {
                    OfficeID = 3,
                    Title = "Some Title3",
                    Location = "Japan",
                },                
                new Office
                {
                    OfficeID = 4,
                    Title = "Some Title4",
                    Location = "Africa",
                },                
                new Office
                {
                    OfficeID = 5,
                    Title = "Some Title5",
                    Location = "UK",
                },
            });
        }
    }
}
