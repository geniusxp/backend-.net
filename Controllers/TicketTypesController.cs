using geniusxp_backend_dotnet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace geniusxp_backend_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Controller de Tipos de Ingresso")]
    public class TicketTypesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TicketTypesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicketType(int id)
        {
            var foundTicketType = await _context.TicketTypes.FindAsync(id);

            if (foundTicketType == null)
            {
                return NotFound();
            }

            _context.TicketTypes.Remove(foundTicketType);
            await _context.SaveChangesAsync();

            return NotFound();
        }
    }
}
