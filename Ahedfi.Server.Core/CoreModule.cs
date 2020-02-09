using Ahedfi.Component.Hosting.Domain.Service;
using Ahedfi.Server.Core.Domain.BusinessService;
using Ahedfi.Server.Core.Domain.Interface;
using Ahedfi.Server.Core.Service;
using Ahedfi.Server.Core.WebApiController;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ahedfi.Server.Core
{
    public class CoreModule : AutofacModule
    {
        public override void RegisterTypes(ContainerBuilder builder)
        {
            // Register Business Service Provider
            builder.RegisterType<BusinessService>().As<IBusinessService>()
             .InstancePerLifetimeScope();

            // Register Service Provider
            builder.RegisterType<CoreService>().As<ICoreService>()
               .InstancePerLifetimeScope();

            // Register Controller
            builder.RegisterType<CoreController>().AsSelf().WithProperty("Value", "PropertyName")
               .InstancePerLifetimeScope();
        }
    }
}
