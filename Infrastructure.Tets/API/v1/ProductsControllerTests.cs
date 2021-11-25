using Application.Features.Queries;
using FakeItEasy;
using MediatR;
using WebAPI.Controllers.v1;
using Xunit;

namespace Infrastructure.Tets.API.v1
{
    public class ProductsControllerTests
    {
        private readonly HousesController controller;
        private readonly IMediator mediator;

        public ProductsControllerTests()
        {
            mediator = A.Fake<IMediator>();
            controller = new HousesController(mediator);
        }

        [Fact]
        public async void Given_ProductsController_When_GetIsCalled_Then_ShouldReturnA_ProductCollection()
        {
            // Arrange&& act
            await controller.Get();
            A.CallTo(() => mediator.Send(A<GetHousesQuery>._, default)).MustHaveHappenedOnceExactly();
        }

    }
}
