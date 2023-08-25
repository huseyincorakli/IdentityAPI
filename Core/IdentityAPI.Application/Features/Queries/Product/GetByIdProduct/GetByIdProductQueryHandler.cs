using IdentityAPI.Application.Repositories.ProductRepositories;
using MediatR;
using P = IdentityAPI.Domain.Entities;

namespace IdentityAPI.Application.Features.Queries.Product.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        public GetByIdProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            P.Product _product =  await _productReadRepository.GetByIdAsync(request.Id);

            return new GetByIdProductQueryResponse
            {
                product = _product,
            };

        }
    }
}
