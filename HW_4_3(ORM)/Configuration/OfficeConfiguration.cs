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
        }
    }
}
