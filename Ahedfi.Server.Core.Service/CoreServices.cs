using Ahedfi.Server.Core.Domain.Interface;
using System.Threading.Tasks;
using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Component.Communication.Domain.Entities;
using Ahedfi.Component.Core.Domain.DependencyInjection.Interfaces;
using Ahedfi.Component.Services.Domain.Services;
using Ahedfi.Component.Security.Domain.Entities;

namespace Ahedfi.Server.Core.Service
{
    public class CoreServices : BaseServiceProvider, ICoreServices
    {
        public CoreServices(IServiceLocator serviceLoactor) : base(serviceLoactor)
        {
        }
        public async Task<SaveResponse<CustomerDto>> AddCustomer(SaveRequest<CustomerDto> request)
        {
            request.Owner = new UserIdentity { UserName = "ahedfi" };// TODO : This line should be removed
            return new SaveResponse<CustomerDto>
            {
                Value = await GetInstance<ICustomerBusinessServiceProvider>().AddCustomerAsync(request.Owner, request.Value)
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
