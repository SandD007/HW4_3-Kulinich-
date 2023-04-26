using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW43
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
               .ToTable("Title");
            
            builder
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasData(new[]
            {
                new Title
                {
                    TitleId = 1,
                    Name = "Title1a",
                },                
                new Title
                {
                    TitleId = 2,
                    Name = "Title2",
                },                
                new Title
                {
                    TitleId = 3,
                    Name = "Title3",
                },                
                new Title
                {
                    TitleId = 4,
                    Name = "Title4a",
                },                
                new Title
                {
                    TitleId = 5,
                    Name = "Title5",
                },
            });
        }
    }
}
