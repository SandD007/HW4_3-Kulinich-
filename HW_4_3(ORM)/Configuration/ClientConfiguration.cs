using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW43
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("Client");
            
            builder
                .Property(x => x.ClientId)
                .IsRequired();

            builder
                .HasData(new[]
                {
                    new Client
                    {
                        ClientId = 1,
                        Name = "Client1",
                    },                   
                    new Client
                    {
                        ClientId = 2,
                        Name = "Client2",
                    },                   
                    new Client
                    {
                        ClientId = 3,
                        Name = "Client3",
                    },                   
                    new Client
                    {
                        ClientId = 4,
                        Name = "Client4",
                    },                   
                    new Client
                    {
                        ClientId = 5,
                        Name = "Client5",
                    },
                });
        }
    }
}
