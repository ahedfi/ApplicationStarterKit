using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Ahedfi.Component.Data.Domain.Interfaces;

namespace Ahedfi.Server.Core.Domain.BusinessService
{
    public class CustomerBusinessServiceProvider : ICustomerBusinessServiceProvider
    {
        private readonly ICoreUnitOfWork _coreUnitOfWork;
        private readonly IMapEngine _mapper;

        public CustomerBusinessServiceProvider(ICoreUnitOfWork coreUnitOfWork, IMapEngine mapper)
        {
            _coreUnitOfWork = coreUnitOfWork;
            _mapper = mapper;
        }
        public async Task<CustomerDto> AddCustomerAsync(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);

            await _coreUnitOfWork.Repository<Customer>().AddAsync(customer);
            await _coreUnitOfWork.CommitAsync();

            return _mapper.Map<CustomerDto>(customer);

        }
        public async Task<IEnumerable<CustomerDto>> FindCustomersAsync()
        {
            var result = await _coreUnitOfWork.Repository<Customer>().ListAllAsync();
            return _mapper.MapList<CustomerDto>(result);
        }
    }
}
