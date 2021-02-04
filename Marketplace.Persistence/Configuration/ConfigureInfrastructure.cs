using Marketplace.Infrastucture.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Infrastucture.Configuration
{
    public class ConfigureInfrastructure
    {
        public static void AddInfrastructureServices(IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:AppDB"];
            services.AddDbContext<AppDBContext>(opts => opts.UseSqlServer(connectionString));
            
        }
    }
}
