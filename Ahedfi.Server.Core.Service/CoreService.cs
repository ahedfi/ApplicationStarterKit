using Ahedfi.Server.Core.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ahedfi.Server.Core.Service
{
    public class CoreService : ICoreService
    {
        private readonly ICustomerBusinessServiceProvider _customerBusinessService;

        public CoreService(ICustomerBusinessServiceProvider customerBusinessService)
        {
            _customerBusinessService = customerBusinessService;
        }
        public async Task AddCustomer()
        {
            await _customerBusinessService.AddCustomer();
        }
    }
}
