using Marketplace.Application.Services.Commands;
using Marketplace.Application.Services.Queries;
using Marketplace.Domain.Interfaces;
using Marketplace.Domain.Services;
using Marketplace.Infrastucture.Network;
using Marketplace.Infrastucture.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Application.Configuration
{
    public class ConfigureApplication
    {
        public static void AddApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IPropertyQuery, PropertyQuery>();
            services.AddScoped<IPropertyCommand, PropertyCommand>();
            services.AddScoped<IPropertyDomainService, PropertyDomainService>();
            services.AddScoped<IPropertyProxy, PropertyProxy>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();
        }
    }
}
