using Ahedfi.Server.Core.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICustomerBusinessServiceProvider
    {
        Task AddCustomerAsync();
        Task<IEnumerable<CustomerDto>> FindCustomersAsync();
    }
}
