using Ahedfi.Component.Hosting.Domain.Services;
using Ahedfi.Server.Core.Domain.BusinessService;
using Ahedfi.Server.Core.Domain.Interface;
using Ahedfi.Server.Core.Service;
using Ahedfi.Server.Core.WebApiController;
using Microsoft.Extensions.DependencyInjection;

namespace Ahedfi.Server.Core
{
    public class CoreModule : BaseModule
    {
        // This module should be loaded first
        public override int Order { get { return 0; } }
        public override void RegisterTypes(IServiceCollection container)
        {
            // Register Business Service Provider
            container.AddScoped<IBusinessService, BusinessService>();

            // Register Service Provider
            container.AddScoped<ICoreService, CoreService>();
        }
    }
}
