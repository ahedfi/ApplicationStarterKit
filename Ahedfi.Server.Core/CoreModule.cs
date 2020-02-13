using Ahedfi.Component.Data.Domain.Interfaces;
using Ahedfi.Component.Data.Infrastructure;
using Ahedfi.Component.Data.Infrastructure.Behaviors;
using Ahedfi.Component.Hosting.Domain.Services;
using Ahedfi.Server.Core.Domain.BusinessService;
using Ahedfi.Server.Core.Domain.Interface;
using Ahedfi.Server.Core.Infrastructure.Data;
using Ahedfi.Server.Core.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ahedfi.Server.Core
{
    public class CoreModule : BaseModule
    {
        // This module should be loaded first
        public override int Order { get { return 0; } }
        public override void RegisterTypes(IConfiguration configuration, IServiceCollection services)
        {
            // Register DbContext
            services.AddDbContext<CoreContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));

            // Register Repositories
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));// TODO : Move To Bootstrap Module
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            // Register Unit Of Work
            services.AddScoped<ICoreUnitOfWork, CoreUnitOfWork>();

            // Register Business Service Provider
            services.AddScoped<ICustomerBusinessServiceProvider, CustomerBusinessServiceProvider>();

            // Register Service Provider
            services.AddScoped<CoreService>();
            services.AddScoped<ICoreService>(service => TransactionBehavior<ICoreService>.Create(
                service.GetService<CoreService>(), 
                service.GetService<ICoreUnitOfWork>()));
        }
    }
}
