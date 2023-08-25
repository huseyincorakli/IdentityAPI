using IdentityAPI.Application.Abstraction.Token;
using IdentityAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
