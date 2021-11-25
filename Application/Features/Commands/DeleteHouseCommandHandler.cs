using Application.Interfaces;
using MediatR;

namespace Application.Features.Commands
{
    public class DeleteHouseCommandHandler : IRequestHandler<DeleteHouseCommand, Guid>
    {
        private readonly IHouseRepository repository;

        public DeleteHouseCommandHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            var house = repository.GetByIdAsync(request.Id).Result;
            if (house == null)
            {
                throw new Exception("House doesn't exist");
            }

            await repository.DeleteAsync(house);

            return house.Id;
        }
    }
}
