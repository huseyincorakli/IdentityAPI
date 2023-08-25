using P = IdentityAPI.Domain.Entities;
namespace IdentityAPI.Application.Features.Queries.Product.GetByIdProduct
{
    public class GetByIdProductQueryResponse
    {
        public P.Product product { get; set; }
    }
}
