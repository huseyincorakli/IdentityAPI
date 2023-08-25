using IdentityAPI.Application.Repositories.ProductRepositories;
using IdentityAPI.Domain.Entities;
using IdentityAPI.Persistence.Contexts;

namespace IdentityAPI.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(IdentityAPIDBContext context) : base(context)
        {
        }
    }
}
