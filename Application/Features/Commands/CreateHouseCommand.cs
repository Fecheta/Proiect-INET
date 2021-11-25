using MediatR;

namespace Application.Features.Commands
{
    public class CreateHouseCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
