using Concert.Api.Data;
using Concert.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concert.Api.Controllers
{
    [ApiController]
    [Route("/api/tickets/")]
    public class TicketController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketController(DataContext dataContext)
        {
            _context = dataContext;
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound("Boleta no válida");
            }
            return Ok(ticket);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Ticket ticket)
        {
            //var tick = await _context.Tickets.FindAsync(ticket.Id);

            //if (tick == null)
            //{
            //    return NotFound();
            //}

            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
            return Ok(ticket);
        }
    }
}
