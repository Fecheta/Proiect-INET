using Domain.Common;

namespace Domain.Entities
{
    public class House : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
