using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;

namespace Infrastructure.Tets
{
    public class DatabaseBaseTest : IDisposable
    {
        protected readonly ProductContext context;

        public DatabaseBaseTest()
        {
            var options = new DbContextOptionsBuilder<ProductContext>().UseInMemoryDatabase("TestDatabase").Options;
            context = new ProductContext(options);
            context.Database.EnsureCreated();
            DatabaseInitializer.Initialize(context);
        }

        public void Dispose()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
