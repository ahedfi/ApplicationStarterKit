using Ahedfi.Server.Core.Domain.Entities;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICustomerBusinessServiceProvider
    {
        Task AddCustomerAsync();
    }
}
