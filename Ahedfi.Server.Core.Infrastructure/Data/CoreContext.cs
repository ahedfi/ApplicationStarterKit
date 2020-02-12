using Ahedfi.Server.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ahedfi.Server.Core.Infrastructure.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options)
        : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
    }
}
