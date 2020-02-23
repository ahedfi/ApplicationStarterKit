using Ahedfi.Component.Communication.Domain.Entities;
using Ahedfi.Component.Core.Domain.DependencyInjection.Interfaces;
using Ahedfi.Component.Hosting.WebApi.Domain.Entities;
using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.WebApiController
{
    [ApiController]
    [Route("api/web/core")]
    public class CoreWebApiController : BaseApiController
    {
        public CoreWebApiController(IServiceLocator serviceLocator) : base(serviceLocator)
        {
        }

        [HttpPost, Route("addCustomer")]
        public async Task<SaveResponse<CustomerDto>> AddAsync(SaveRequest<CustomerDto> request)
        {
            try
            {
                return await GetInstance<ICoreServices>().AddCustomerAsync(request);
            }
            catch (Exception ex)
            {

                return new SaveResponse<CustomerDto>() { Exception = new Exception(ex.GetBaseException().Message) };
            }
        }

        [HttpPost, Route("customers")]
        public async Task<FindResponse<CustomerDto>> GetAllAsync(FindRequest request)
        {
            try
            {
                return await GetInstance<ICoreServices>().FindAllCustomersAsync(request);
            }
            catch (Exception ex)
            {

                return new FindResponse<CustomerDto>() { Exception = new Exception(ex.GetBaseException().Message) };
            }
        }
    }
}
