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
        public async Task<CustomerDto> AddCustomerAsync(CustomerDto customerDto)
        {
            var customer = new Customer
            {
                Name = customerDto.Name,
                CreatedOn = DateTime.Now,
                CreatedBy = "ahedfi"
            };
            await _coreUnitOfWork.Repository<Customer>().AddAsync(customer);
            await _coreUnitOfWork.CommitAsync();
            return new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name,
            };
        }

        public async Task<IEnumerable<CustomerDto>> FindCustomersAsync()
        {
            var result = await _coreUnitOfWork.Repository<Customer>().ListAllAsync();
            return result.Select(e => new CustomerDto
            {
                Id = e.Id,
                Name = e.Name,
            });
        }
    }
}
