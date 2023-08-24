using IdentityAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityAPI.Persistence.Contexts
{
    public class IdentityAPIDBContext : DbContext
    {
        public IdentityAPIDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
