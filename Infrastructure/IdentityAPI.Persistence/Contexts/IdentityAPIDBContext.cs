using IdentityAPI.Domain.Entities;
using IdentityAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAPI.Persistence.Contexts
{
    public class IdentityAPIDBContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public IdentityAPIDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
