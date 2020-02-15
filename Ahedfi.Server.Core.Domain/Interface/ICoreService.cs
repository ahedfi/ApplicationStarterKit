using Ahedfi.Component.Services.Domain.Inerfaces;
using Ahedfi.Server.Core.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICoreService
    {
        Task AddCustomer();
        Task<IEnumerable<CustomerDto>> FindAllCustomers();
    }
}
