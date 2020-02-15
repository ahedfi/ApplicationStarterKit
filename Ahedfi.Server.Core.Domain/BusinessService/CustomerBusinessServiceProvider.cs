using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

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
            await _coreUnitOfWork.Repository<Customer>().AddAsync(new Customer { Name = "Customer " +  Guid.NewGuid() });
            await _coreUnitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<CustomerDto>> FindCustomersAsync()
        {
            var result = await _coreUnitOfWork.Repository<Customer>().ListAllAsync();
            return result.Select(e => new CustomerDto { 
                Id = e.Id,
                Name = e.Name,
            });
        }
    }
}
