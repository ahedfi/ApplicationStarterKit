using Ahedfi.Component.Services.Domain.Inerfaces;
using Ahedfi.Server.Core.Domain.Interface;
using System.Threading.Tasks;
using Ahedfi.Component.Services.Infrastructure;
using System.Collections.Generic;
using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Component.Communication.Domain.Entities;

namespace Ahedfi.Server.Core.Service
{
    public class CoreService : BaseServiceProvider, ICoreService
    {
        public CoreService(IServiceLocator serviceLoactor) : base(serviceLoactor)
        {
        }
        public async Task<SaveResponse<CustomerDto>> AddCustomer(SaveRequest<CustomerDto> request)
        {
            return new SaveResponse<CustomerDto>
            {
                Value = await GetInstance<ICustomerBusinessServiceProvider>().AddCustomerAsync(request.Value)
            };
        }
        public async Task<FindResponse<CustomerDto>> FindAllCustomersAsync(FindRequest request)
        {
            return new FindResponse<CustomerDto>
            {
                Value = await GetInstance<ICustomerBusinessServiceProvider>().FindCustomersAsync()
            };
        }
    }
}
