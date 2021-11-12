using Domain.Entities;
using MediatR;

namespace Application.Features.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
