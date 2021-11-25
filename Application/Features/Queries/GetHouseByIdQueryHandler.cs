using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Queries
{
    public class GetHouseByIdQueryHandler : IRequestHandler<GetHouseByIdQuery, House>
    {
        private readonly IHouseRepository repository;

        public GetHouseByIdQueryHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<House> Handle(GetHouseByIdQuery request, CancellationToken cancellationToken)
        {
            var house = await repository.GetByIdAsync(request.Id);
            if (house == null)
            {
                throw new Exception("House doesn't exist");
            }

            return house;
        }
    }
}
