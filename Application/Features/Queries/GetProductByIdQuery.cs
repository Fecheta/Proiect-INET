using Domain.Entities;
using MediatR;

namespace Application.Features.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}
