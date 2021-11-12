using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationContext
    {
        DbSet<Domain.Entities.Product> Products { get; set; }

        Task<int> SaveChangesAsync();
    }
}
