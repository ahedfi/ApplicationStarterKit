using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
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

        [HttpGet]
        public async Task Get()
        {
             await _coreService.AddCustomer();
        }

        [HttpGet("customers")]
        public async Task<IEnumerable<CustomerDto>> GetAll()
        {
            return await _coreService.FindAllCustomers();
        }
    }
}
