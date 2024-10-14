using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InstitutoBack.DataContext;
using InstitutoServices.Models.Commons;

namespace InstitutoBack.Controllers.Commons
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiJefaturasSeccionesController : ControllerBase
    {
        private readonly InstitutoContext _context;

        public ApiJefaturasSeccionesController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: api/ApiJefaturasSecciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JefaturaSeccion>>> Getjefaturassecciones()
        {
            return await _context.jefaturassecciones.ToListAsync();
        }

        // GET: api/ApiJefaturasSecciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JefaturaSeccion>> GetJefaturaSeccion(int id)
        {
            var jefaturaSeccion = await _context.jefaturassecciones.FindAsync(id);

            if (jefaturaSeccion == null)
            {
                return NotFound();
            }

            return jefaturaSeccion;
        }

        //agrego un metodo que obtenga las jefaturas de sección que tiene un determinado docente
        [HttpGet("getByDocente")]
        public async Task<ActionResult<IEnumerable<JefaturaSeccion>>> GetJefaturasByAlumno([FromQuery] int docenteId)
        {
            return await _context.jefaturassecciones.Include(i => i.Carrera).Where(i => i.DocenteId == docenteId).ToListAsync();
        }

        // PUT: api/ApiJefaturasSecciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJefaturaSeccion(int id, JefaturaSeccion jefaturaSeccion)
        {
            if (id != jefaturaSeccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(jefaturaSeccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JefaturaSeccionExists(id))
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

        // POST: api/ApiJefaturasSecciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JefaturaSeccion>> PostJefaturaSeccion(JefaturaSeccion jefaturaSeccion)
        {
            _context.jefaturassecciones.Add(jefaturaSeccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJefaturaSeccion", new { id = jefaturaSeccion.Id }, jefaturaSeccion);
        }

        // DELETE: api/ApiJefaturasSecciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJefaturaSeccion(int id)
        {
            var jefaturaSeccion = await _context.jefaturassecciones.FindAsync(id);
            if (jefaturaSeccion == null)
            {
                return NotFound();
            }
            jefaturaSeccion.Eliminado=true;
            _context.jefaturassecciones.Update(jefaturaSeccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JefaturaSeccionExists(int id)
        {
            return _context.jefaturassecciones.Any(e => e.Id == id);
        }
    }
}
