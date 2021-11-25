using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;

namespace Infrastructure.Tets
{
    public class DatabaseBaseTest : IDisposable
    {
        protected readonly HouseContext context;

        public DatabaseBaseTest()
        {
            var options = new DbContextOptionsBuilder<HouseContext>().UseInMemoryDatabase("TestDatabase").Options;
            context = new HouseContext(options);
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
