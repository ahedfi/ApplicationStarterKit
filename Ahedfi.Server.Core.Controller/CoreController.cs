using Ahedfi.Server.Core.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core.WebApiController
{
    [ApiController]
    [Route("api/core")]
    public class CoreController : ControllerBase
    {
        private readonly ICoreService _coreService;

        public CoreController(ICoreService coreService)
        {
            _coreService = coreService;
        }

        public string Value { get; set; }

        [HttpGet]
        public string Get()
        {
            return _coreService.SayHello();
        }
    }
}
