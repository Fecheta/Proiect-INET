using Application.Interfaces;
using MediatR;

namespace Application.Features.Commands
{
    public class UpdateHouseCommandHandler : IRequestHandler<UpdateHouseCommand, Guid>
    {
        private readonly IHouseRepository repository;

        public UpdateHouseCommandHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(UpdateHouseCommand request, CancellationToken cancellationToken)
        {
            var house = repository.GetByIdAsync(request.Id).Result;
            if (house == null || house.Id == Guid.Empty)
            {
                throw new Exception("House doesn't exist!");
            }

            house.Name = request.Name;
            house.Price = request.Price;

            await repository.UpdateAsync(house);

            return house.Id;
                
        }
    }
}
