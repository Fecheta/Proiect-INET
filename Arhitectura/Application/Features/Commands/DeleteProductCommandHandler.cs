using Application.Interfaces;
using MediatR;

namespace Application.Features.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Guid>
    {
        private readonly IProductRepository repository;

        public DeleteProductCommandHandler(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = repository.GetByIdAsync(request.Id).Result;
            if (product == null)
            {
                throw new Exception("Product doesn't exist");
            }

            await repository.DeleteAsync(product);

            return product.Id;
        }
    }
}
