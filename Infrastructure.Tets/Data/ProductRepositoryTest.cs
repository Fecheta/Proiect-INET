using Domain.Entities;
using FluentAssertions;
using Persistence.v1;
using System;
using Xunit;

namespace Infrastructure.Tets.Data
{
    public class ProductRepositoryTest : DatabaseBaseTest
    {
        private readonly Repository<House> repository;
        private readonly House newProduct;

        public ProductRepositoryTest()
        {
            repository = new Repository<House>(context);
            newProduct = new House()
            {
                Id = Guid.Parse("2cbda575-865e-4ecc-ab48-24e82f2e39f8"),
                Name = "Keyboard",
                Price = 20
            };
        }

        // GIVEN WHEN THEN
        [Fact]
        public async void Given_NewProduct_WhenProductIsNotNull_Then_AddAsyncShouldReturnANewProduct()
        {
            // AAA
            // Arrange && act
            var result = await repository.AddAsync(newProduct);

            // Assert
            result.Should().BeOfType<House>();
        }
    }
}
