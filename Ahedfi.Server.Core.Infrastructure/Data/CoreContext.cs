using Ahedfi.Server.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Ahedfi.Server.Core.Infrastructure.Data
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;

        int SaveChanges();

        void Dispose();
    }

    public class CommonContext : DbContext, IDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Core;Integrated Security=True");
        }
    }
    public class CoreContext : CommonContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
