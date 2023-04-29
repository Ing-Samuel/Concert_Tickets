using Concert.Shared.Entities;

namespace Concert.Api.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.SaveChangesAsync();
            await CheckTicketsAsync();
        }

        public async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                var tickets = new List<Ticket>();

                for (int i = 0; i < 50000; i++)
                {
                    tickets.Add(new Ticket { UseDate = null, EntrySite = null, Used = false });
                }

                await _context.Tickets.AddRangeAsync(tickets);
                await _context.SaveChangesAsync();
            }
        }
    }

}
