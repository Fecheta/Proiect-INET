using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationContext
    {
        DbSet<Domain.Entities.House> Products { get; set; }

        Task<int> SaveChangesAsync();
    }
}
