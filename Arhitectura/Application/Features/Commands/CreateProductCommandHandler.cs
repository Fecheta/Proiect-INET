using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Barcode = request.Barcode,
                Price = request.Price
            };

            await repository.AddAsync(product);
            return product.Id;
        }
    }
}
