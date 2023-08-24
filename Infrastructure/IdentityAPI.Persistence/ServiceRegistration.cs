using IdentityAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace IdentityAPI.Persistence
{
    public static class ServiceRegistration
    {
      
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<IdentityAPIDBContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
