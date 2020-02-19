using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Ahedfi.Server.Core.Infrastructure.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        { }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
        }
    }
}
