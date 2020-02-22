using Ahedfi.Component.Communication.Domain.Entities;
using Ahedfi.Component.Services.Domain.Inerfaces;
using Ahedfi.Server.Core.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Domain.Interface
{
    public interface ICoreServices
    {
        Task<SaveResponse<CustomerDto>> AddCustomerAsync(SaveRequest<CustomerDto> request);
        Task<FindResponse<CustomerDto>> FindAllCustomersAsync(FindRequest request);
    }
}
