using Application.Interfaces;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.v1
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }
    }
}
