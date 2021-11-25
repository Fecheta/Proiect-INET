using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository repository;

        public GetProductByIdQueryHandler(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await repository.GetByIdAsync(request.Id);
            if (product == null)
            {
                throw new Exception("Product doesn't exist");
            }

            return product;
        }
    }
}
