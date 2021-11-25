using Domain.Entities;
using Persistence.Context;
using System;
using System.Linq;

namespace Infrastructure.Tets
{
    public class DatabaseInitializer
    {
        public static void Initialize(HouseContext context)
        {
            if (context.Houses.Any())
            {
                return;
            }
            Seed(context);
        }

        private static void Seed(HouseContext context)
        {
            var products = new[]
            {
                new House
                {
                    Id = Guid.Parse("3eae2248-1055-4029-84fe-0f4ad6c4fed0"),
                    Name = "Computer",
                    Price = 600
                },
                new House
                {
                    Id = Guid.Parse("d911605e-7842-4229-a37c-20b432c9d678"),
                    Name = "Laptop",
                    Price = 900
                }
            };

            context.Houses.AddRange(products);
            context.SaveChanges();
        }
    }
}
