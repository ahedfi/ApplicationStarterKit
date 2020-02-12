using Ahedfi.Component.Data.Infrastructure;
using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Domain.Interface;

namespace Ahedfi.Server.Core.Infrastructure.Data
{
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CoreContext dbContext) : base(dbContext)
        {
        }
    }
}
