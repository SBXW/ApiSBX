using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_SBX.Models;

namespace API_SBX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadMedidumsController : ControllerBase
    {
        private readonly db_sbxContext _context;

        public UnidadMedidumsController(db_sbxContext context)
        {
            _context = context;
        }

        // GET: api/UnidadMedidums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadMedidum>>> GetUnidadMedida()
        {
            return await _context.UnidadMedida.ToListAsync();
        }

        // GET: api/UnidadMedidums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadMedidum>> GetUnidadMedidum(int id)
        {
            var unidadMedidum = await _context.UnidadMedida.FindAsync(id);

            if (unidadMedidum == null)
            {
                return NotFound();
            }

            return unidadMedidum;
        }

        // PUT: api/UnidadMedidums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidadMedidum(int id, UnidadMedidum unidadMedidum)
        {
            if (id != unidadMedidum.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(unidadMedidum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadMedidumExists(id))
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

        // POST: api/UnidadMedidums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UnidadMedidum>> PostUnidadMedidum(UnidadMedidum unidadMedidum)
        {
            _context.UnidadMedida.Add(unidadMedidum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnidadMedidum", new { id = unidadMedidum.Codigo }, unidadMedidum);
        }

        // DELETE: api/UnidadMedidums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnidadMedidum(int id)
        {
            var unidadMedidum = await _context.UnidadMedida.FindAsync(id);
            if (unidadMedidum == null)
            {
                return NotFound();
            }

            _context.UnidadMedida.Remove(unidadMedidum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnidadMedidumExists(int id)
        {
            return _context.UnidadMedida.Any(e => e.Codigo == id);
        }
    }
}
