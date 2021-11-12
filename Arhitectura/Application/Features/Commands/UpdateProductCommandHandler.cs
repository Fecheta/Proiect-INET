using Application.Interfaces;
using MediatR;

namespace Application.Features.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Guid>
    {
        private readonly IProductRepository repository;

        public UpdateProductCommandHandler(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = repository.GetByIdAsync(request.Id).Result;
            if (product == null || product.Id == Guid.Empty)
            {
                throw new Exception("Product doesn't exist!");
            }

            product.Name = request.Name;
            product.Barcode = request.Barcode;
            product.Price = request.Price;

            await repository.UpdateAsync(product);

            return product.Id;
                
        }
    }
}
