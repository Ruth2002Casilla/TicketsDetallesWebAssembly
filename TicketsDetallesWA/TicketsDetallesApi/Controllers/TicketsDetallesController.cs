using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaModels.Models;
using TicketsDetallesApi.Server.DAL;

namespace TicketsDetallesApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsDetallesController : ControllerBase
    {
        private readonly Context _context;

        public TicketsDetallesController(Context context)
        {
            _context = context;
        }

        // GET: api/TicketsDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketsDetalles>>> GetTicketsDetalle()
        {
            return await _context.TicketsDetalle.ToListAsync();
        }

        // GET: api/TicketsDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketsDetalles>> GetTicketsDetalles(int id)
        {
            var ticketsDetalles = await _context.TicketsDetalle.FindAsync(id);

            if (ticketsDetalles == null)
            {
                return NotFound();
            }

            return ticketsDetalles;
        }

        // PUT: api/TicketsDetalles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicketsDetalles(int id, TicketsDetalles ticketsDetalles)
        {
            if (id != ticketsDetalles.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticketsDetalles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketsDetallesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TicketsDetalles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TicketsDetalles>> PostTicketsDetalles(TicketsDetalles ticketsDetalles)
        {
            _context.TicketsDetalle.Add(ticketsDetalles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicketsDetalles", new { id = ticketsDetalles.Id }, ticketsDetalles);
        }

        // DELETE: api/TicketsDetalles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicketsDetalles(int id)
        {
            var ticketsDetalles = await _context.TicketsDetalle.FindAsync(id);
            if (ticketsDetalles == null)
            {
                return NotFound();
            }

            _context.TicketsDetalle.Remove(ticketsDetalles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketsDetallesExists(int id)
        {
            return _context.TicketsDetalle.Any(e => e.Id == id);
        }
    }
}
