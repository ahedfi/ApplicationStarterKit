using Ahedfi.Component.Core.Domain.Security.Interfaces;
using Ahedfi.Server.Core.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICustomerBusinessServiceProvider
    {
        Task<CustomerDto> AddCustomerAsync(IUserIdentity user, CustomerDto customerDto);
        Task<IEnumerable<CustomerDto>> FindCustomersAsync();
    }
}
