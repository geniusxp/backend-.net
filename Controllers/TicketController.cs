using geniusxp_backend_dotnet.Builders;
using geniusxp_backend_dotnet.Data;
using geniusxp_backend_dotnet.Requests;
using geniusxp_backend_dotnet.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace geniusxp_backend_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Controller de Ingressos")]
    public class TicketController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TicketController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<TicketSimplifiedResponse>> CreateTicket(CreateTicketRequest request)
        {
            var user = await _context.Users.FindAsync(request.UserId);
            var ticketType = await _context.TicketTypes.FindAsync(request.TicketTypeId);

            if (user == null || ticketType == null)
            {
                return NotFound();
            }

            var ticketBuilder = new TicketBuilder();

            var newTicket = ticketBuilder
                .DateIssued()
                .TicketType(ticketType)
                .User(user)
                .TicketNumber()
                .Build();
            
            _context.Tickets.Add(newTicket);
            await _context.SaveChangesAsync();

            var createdTicket = TicketSimplifiedResponse.From(newTicket);

            return CreatedAtAction("FindTicketById", new { id = createdTicket.Id }, createdTicket);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var foundTicket = await _context.Tickets.FindAsync(id);

            if (foundTicket == null)
            {
                return NotFound();
            }

            _context.Tickets.Remove(foundTicket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> ValidateTicket(Guid ticketNumber)
        {
            var foundTicket = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketNumber == ticketNumber.ToString());

            if (foundTicket == null)
            {
                return NotFound();
            }

            if (foundTicket.DateOfUse != null)
            {
                return BadRequest("Ingresso já foi utilizado!");
            }

            foundTicket.DateOfUse = DateTime.Now;
            _context.Tickets.Update(foundTicket);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
