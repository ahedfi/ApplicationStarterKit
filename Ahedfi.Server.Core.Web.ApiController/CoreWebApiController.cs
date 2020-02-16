using Ahedfi.Component.Communication.Domain.Entities;
using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.WebApiController
{
    [ApiController]
    [Route("api/web/core")]
    public class CoreWebApiController : ControllerBase
    {
        private readonly ICoreService _coreService;

        public CoreWebApiController(ICoreService coreService)
        {
             _coreService = coreService;
        }

        [HttpPost, Route("addCustomer")]
        public async Task<SaveResponse<CustomerDto>> AddAsync(SaveRequest<CustomerDto> request)
        {
            try
            {
                return await _coreService.AddCustomer(request);
            }
            catch (Exception ex)
            {

                return new SaveResponse<CustomerDto>() { Exception = ex };
            }
        }

        [HttpPost, Route("customers")]
        public async Task<FindResponse<CustomerDto>> GetAllAsync(FindRequest request)
        {
            try
            {
                return await _coreService.FindAllCustomersAsync(request);
            }
            catch (Exception ex)
            {

                return new FindResponse<CustomerDto>() { Exception = ex };
            }
        }
    }
}
