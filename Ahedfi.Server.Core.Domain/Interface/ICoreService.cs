using Ahedfi.Component.Services.Domain.Inerfaces;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICoreService : IServicesProvider
    {
        Task AddCustomer();
    }
}
