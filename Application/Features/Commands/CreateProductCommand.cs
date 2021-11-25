using MediatR;

namespace Application.Features.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public string Barcode { get; set; }

        public decimal Price { get; set; }
    }
}
