using Ahedfi.Component.Services.Domain.Inerfaces;
using Ahedfi.Server.Core.Domain.Interface;
using System.Threading.Tasks;
using Ahedfi.Component.Services.Infrastructure;
using System.Collections.Generic;
using Ahedfi.Server.Core.Domain.Dtos;

namespace Ahedfi.Server.Core.Service
{
    public class CoreService : BaseServiceProvider, ICoreService
    {
        public CoreService(IServiceLocator serviceLoactor) : base(serviceLoactor)
        {
        }
        public async Task AddCustomer()
        {
            await GetInstance<ICustomerBusinessServiceProvider>().AddCustomerAsync();
        }

        public async Task<IEnumerable<CustomerDto>> FindAllCustomers()
        {
            return await GetInstance<ICustomerBusinessServiceProvider>().FindCustomersAsync();
        }
    }
}
