using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Domain.Interface;
using System;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.BusinessService
{
    public class CustomerBusinessServiceProvider : ICustomerBusinessServiceProvider
    {
        private readonly ICoreUnitOfWork _coreUnitOfWork;

        public CustomerBusinessServiceProvider(ICoreUnitOfWork coreUnitOfWork)
        {
            _coreUnitOfWork = coreUnitOfWork;
        }
        public async Task AddCustomerAsync()
        {
            await _coreUnitOfWork.Repository<Customer>().AddAsync(new Customer { Name = "new entry02" + new Guid().ToString() });
        }
    }
}
