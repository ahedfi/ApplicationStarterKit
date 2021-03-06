﻿using Ahedfi.Server.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ahedfi.Server.Core.Infrastructure.Data.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("APP_CUS_Customers");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
           .IsRequired();
        }
    }
}
