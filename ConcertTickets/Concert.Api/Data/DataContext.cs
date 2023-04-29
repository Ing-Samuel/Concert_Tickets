using Concert.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Concert.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

    }
}
