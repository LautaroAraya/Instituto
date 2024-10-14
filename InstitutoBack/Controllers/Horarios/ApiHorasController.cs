using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InstitutoServices.Models;
using InstitutoBack.DataContext;
using InstitutoServices.Models.Horarios;

namespace InstitutoBack.Controllers.Horarios
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiHorasController : ControllerBase
    {
        private readonly InstitutoContext _context;

        public ApiHorasController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: api/ApiHoras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hora>>> Gethoras()
        {
            return await _context.horas.OrderBy(h=>h.Desde).ToListAsync();
        }

        // GET: api/ApiHoras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hora>> GetHora(int id)
        {
            var hora = await _context.horas.FindAsync(id);

            if (hora == null)
            {
                return NotFound();
            }

            return hora;
        }

        // PUT: api/ApiHoras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHora(int id, Hora hora)
        {
            if (id != hora.Id)
            {
                return BadRequest();
            }

            _context.Entry(hora).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoraExists(id))
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

        // POST: api/ApiHoras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hora>> PostHora(Hora hora)
        {
            _context.horas.Add(hora);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHora", new { id = hora.Id }, hora);
        }

        // DELETE: api/ApiHoras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHora(int id)
        {
            var hora = await _context.horas.FindAsync(id);
            if (hora == null)
            {
                return NotFound();
            }

            hora.Eliminado = true;
            _context.horas.Update(hora);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HoraExists(int id)
        {
            return _context.horas.Any(e => e.Id == id);
        }
    }
}
