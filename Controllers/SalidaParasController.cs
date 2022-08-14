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
    public class SalidaParasController : ControllerBase
    {
        private readonly db_sbxContext _context;

        public SalidaParasController(db_sbxContext context)
        {
            _context = context;
        }

        // GET: api/SalidaParas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalidaPara>>> GetSalidaParas()
        {
            return await _context.SalidaParas.ToListAsync();
        }

        // GET: api/SalidaParas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalidaPara>> GetSalidaPara(int id)
        {
            var salidaPara = await _context.SalidaParas.FindAsync(id);

            if (salidaPara == null)
            {
                return NotFound();
            }

            return salidaPara;
        }

        // PUT: api/SalidaParas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalidaPara(int id, SalidaPara salidaPara)
        {
            if (id != salidaPara.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(salidaPara).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalidaParaExists(id))
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

        // POST: api/SalidaParas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalidaPara>> PostSalidaPara(SalidaPara salidaPara)
        {
            _context.SalidaParas.Add(salidaPara);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalidaPara", new { id = salidaPara.Codigo }, salidaPara);
        }

        // DELETE: api/SalidaParas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalidaPara(int id)
        {
            var salidaPara = await _context.SalidaParas.FindAsync(id);
            if (salidaPara == null)
            {
                return NotFound();
            }

            _context.SalidaParas.Remove(salidaPara);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalidaParaExists(int id)
        {
            return _context.SalidaParas.Any(e => e.Codigo == id);
        }
    }
}
