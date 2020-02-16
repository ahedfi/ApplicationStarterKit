using Ahedfi.Component.Data.Domain.Interfaces;
using Ahedfi.Component.Data.Infrastructure;
using Ahedfi.Component.Hosting.Domain.Services;
using Ahedfi.Component.Services.Domain.Inerfaces;
using Ahedfi.Component.Services.Infrastructure;
using Ahedfi.Server.Core.Domain.BusinessService;
using Ahedfi.Server.Core.Domain.Interface;
using Ahedfi.Server.Core.Infrastructure.Data;
using Ahedfi.Server.Core.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ahedfi.Component.Hosting.Domain.Extensions;
using Ahedfi.Component.Hosting.Infrastructure.Behaviors;
using AutoMapper;
using Ahedfi.Server.Core.Infrastructure.Profiles;
using System.Reflection;
using FluentValidation.AspNetCore;

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
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            // Register Unit Of Work
            services.AddScoped<ICoreUnitOfWork, CoreUnitOfWork>();

            // Register AutoMapper
            services.AddAutoMapper(Assembly.Load("Ahedfi.Server.Core.Infrastructure"));
            
            // Register Fluent Validation
            services.AddControllers() 
                    .AddFluentValidation(opt =>
                    {
                        opt.RegisterValidatorsFromAssembly(Assembly.Load("Ahedfi.Server.Core.Infrastructure"));
                    });
            
            // Register Business Service Provider
            services.AddScoped<ICustomerBusinessServiceProvider, CustomerBusinessServiceProvider>();
            services.DecorateWithDispatchProxyAsync<ICustomerBusinessServiceProvider, LogBehavior<ICustomerBusinessServiceProvider>>();

            // Register Service Provider
            services.AddScoped<ICoreServices, CoreServices>();
            services.DecorateWithDispatchProxyAsync<ICoreServices, LogBehavior<ICoreServices>>();
            services.DecorateWithDispatchProxyAsync<ICoreServices, TransactionBehavior<ICoreServices>>();
        }
    }
}
