using Ahedfi.Component.Services.Domain.Inerfaces;
using Ahedfi.Server.Core.Domain.Interface;
using System.Threading.Tasks;
using Ahedfi.Component.Services.Infrastructure;

namespace Ahedfi.Server.Core.Service
{
    public class CoreService : BaseServiceProvider, ICoreService
    {
        public CoreService(IServiceLocator serviceLoactor):base(serviceLoactor)
        {
        }
        public async Task AddCustomer()
        {
            await GetInstance<ICustomerBusinessServiceProvider>().AddCustomerAsync();
        }
    }
}
