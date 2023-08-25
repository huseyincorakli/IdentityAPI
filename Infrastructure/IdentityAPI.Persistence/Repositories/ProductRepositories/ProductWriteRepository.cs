using IdentityAPI.Application.Repositories.ProductRepositories;
using IdentityAPI.Domain.Entities;
using IdentityAPI.Persistence.Contexts;

namespace IdentityAPI.Persistence.Repositories.ProductRepositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(IdentityAPIDBContext context) : base(context)
        {
        }
    }
}
