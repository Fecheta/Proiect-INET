using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands
{
    public class CreateHouseCommandHandler : IRequestHandler<CreateHouseCommand, Guid>
    {
        private readonly IHouseRepository repository;

        public CreateHouseCommandHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(CreateHouseCommand request, CancellationToken cancellationToken)
        {
            var house = new House
            {
                Name = request.Name,
                Price = request.Price
            };

            await repository.AddAsync(house);
            return house.Id;
        }
    }
}
