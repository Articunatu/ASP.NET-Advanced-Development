using Microsoft.EntityFrameworkCore;

namespace API_Angular_CRUD.Models
{
    public class CardsDbContext : DbContext
    {

        public CardsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Card> Cards { get; set; }
    }
}
