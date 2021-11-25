using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class HouseContext : DbContext
    {
        //public ProductContext()
        //{

        //}
        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {
        }

        public DbSet<House> Houses { get ; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=MyProducts.db");
        // }
    }
}
