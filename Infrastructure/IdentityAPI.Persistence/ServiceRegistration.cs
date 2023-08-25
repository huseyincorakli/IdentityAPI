using IdentityAPI.Application.Abstraction.Services;
using IdentityAPI.Application.Repositories.ProductRepositories;
using IdentityAPI.Domain.Entities.Identity;
using IdentityAPI.Persistence.Contexts;
using IdentityAPI.Persistence.Repositories.ProductRepositories;
using IdentityAPI.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace IdentityAPI.Persistence
{
    public static class ServiceRegistration
    {
      
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<IdentityAPIDBContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService,AuthService>();

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.ClaimsIdentity.EmailClaimType = ClaimTypes.Email;
                options.User.RequireUniqueEmail= true;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric= false;
                options.Password.RequiredLength= 3;
            }).AddEntityFrameworkStores<IdentityAPIDBContext>();
        }
    }
}
