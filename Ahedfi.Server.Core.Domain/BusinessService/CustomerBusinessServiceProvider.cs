using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Entities;
using Ahedfi.Server.Core.Domain.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ahedfi.Component.Data.Domain.Interfaces;
using Ahedfi.Component.Services.Domain.Services;
using Ahedfi.Component.Core.Domain.Security.Interfaces;

namespace Ahedfi.Server.Core.Domain.BusinessService
{
    public class CustomerBusinessServiceProvider : BaseBusinessServiceProvider<Customer>, ICustomerBusinessServiceProvider
    {
        private readonly ICoreUnitOfWork _coreUnitOfWork;
        public CustomerBusinessServiceProvider(ICoreUnitOfWork coreUnitOfWork, IMapEngine mapper) : base(coreUnitOfWork, mapper)
        {
            _coreUnitOfWork = coreUnitOfWork;
        }
        public async Task<CustomerDto> AddCustomerAsync(IUserIdentity user, CustomerDto customerDto)
        {
            var customer = Mapper.Map<Customer>(customerDto);

            await base.SaveAsync(user.UserName, customer);

            return Mapper.Map<CustomerDto>(customer);
        }
        public async Task<IEnumerable<CustomerDto>> FindCustomersAsync()
        {
            var result = await base.FindAllAsync();
            return Mapper.MapList<CustomerDto>(result);
        }
    }
}
