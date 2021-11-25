using Domain.Entities;
using FakeItEasy;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Tets.Service
{
    public class CreateProductCommandHandlerTests
    {
        private readonly Application.Features.Commands.CreateHouseCommandHandler handler;
        private readonly Application.Interfaces.IHouseRepository repository;

        public CreateProductCommandHandlerTests()
        {
            this.repository= A.Fake<Application.Interfaces.IHouseRepository>();
            this.handler = new Application.Features.Commands.CreateHouseCommandHandler(this.repository);
        }

        [Fact]
        public async Task Given_CreateProductCommandHandler_When_HandleISCalled_Then_AddAsyncProductIsCalled()
        {
            // Arrange & Act
            await handler.Handle(new Application.Features.Commands.CreateHouseCommand(), default);
            // Assert
            A.CallTo(() => repository.AddAsync(A<House>._)).MustHaveHappenedOnceExactly();
        }
    }
}
