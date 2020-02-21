using Ahedfi.Server.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ahedfi.Server.Core.Infrastructure.Data.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("APP_ADD_Adresses");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Street)
           .IsRequired();
        }
    }
}
