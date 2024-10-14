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
    public class ApiHorariosController : ControllerBase
    {
        private readonly InstitutoContext _context;

        public ApiHorariosController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: api/ApiHorarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horario>>> Gethorarios([FromQuery]int? idCicloLectivo, int? idCarrera, int? idAnioCarrera)
        {
            if (idAnioCarrera != null && idCicloLectivo!=null)
            {
                return await _context.horarios.Include(h=>h.DetallesHorario).ThenInclude(d=>d.Hora).
                                               Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera).
                                               Include(h=> h.IntegrantesHorario).ThenInclude(i => i.Docente)
                                               .Where(h => h.Materia.AnioCarreraId.Equals(idAnioCarrera)&&h.CicloLectivoId.Equals(idCicloLectivo)).ToListAsync();
            }
            else
            {
                if (idCarrera != null && idCicloLectivo != null)
                {
                    return await _context.horarios.Include(h => h.DetallesHorario).ThenInclude(d => d.Hora)
                                               .Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera)
                                               .Include(h => h.IntegrantesHorario).ThenInclude(i => i.Docente)
                                               .Where(h => h.Materia.AnioCarrera.CarreraId.Equals(idCarrera) && h.CicloLectivoId.Equals(idCicloLectivo)).ToListAsync();
                }
                else
                {
                    if(idCicloLectivo != null)
                    {
                        return await _context.horarios.Include(h => h.DetallesHorario).ThenInclude(d => d.Hora)
                            .Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera)
                            .Include(h => h.IntegrantesHorario).ThenInclude(i => i.Docente)
                            .Where(h => h.CicloLectivoId.Equals(idCicloLectivo)).ToListAsync();
                    }
                }    
            }
                
            return await _context.horarios.Include(h => h.DetallesHorario).ThenInclude(d => d.Hora)
                            .Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera)
                            .Include(h => h.IntegrantesHorario).ThenInclude(i => i.Docente)
                            .ToListAsync();
        }

        // GET: api/ApiHorarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Horario>> GetHorario(int id)
        {
            var horario = await _context.horarios
                .Include(h => h.DetallesHorario).ThenInclude(d => d.Hora)
                            .Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera)
                            .Include(h => h.IntegrantesHorario).ThenInclude(i => i.Docente)
                .Where(h=>h.Id.Equals(id)).FirstOrDefaultAsync();

            if (horario == null)
            {
                return NotFound();
            }

            return horario;
        }

        // PUT: api/ApiHorarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHorario(int id, Horario horario)
        {
            if (id != horario.Id)
            {
                return BadRequest();
            }
            // Marcar el horario como modificado
            _context.Entry(horario).State = EntityState.Modified;


            //busco los detalles existentes
            var detallesExistentes = _context.detalleshorarios.Where(d => d.HorarioId.Equals(horario.Id)).AsNoTracking().ToList();
            //busco los integrantes existentes
            var integrantesExistentes = _context.integranteshorarios.Where(i => i.HorarioId.Equals(horario.Id)).AsNoTracking().ToList();

            //busco los detalles que se eliminaron
            var detallesEliminados = detallesExistentes.Where(d => !horario.DetallesHorario.Any(dh => dh.Id == d.Id)).ToList();
            //busco los integrantes que se eliminaron
            var integrantesEliminados = integrantesExistentes.Where(i => !horario.IntegrantesHorario.Any(ih => ih.Id == i.Id)).ToList();

            foreach (var detalle in horario.DetallesHorario)
            {
                if (detalle.Id == 0)
                {
                    _context.detalleshorarios.Add(detalle);
                }
                else
                {
                    _context.Entry(detalle).State = EntityState.Modified;
                }
            }

            //recorro los integrantes y los marco como modificados
            foreach (var integrante in horario.IntegrantesHorario)
            {
                if (integrante.Id == 0)
                {
                    _context.integranteshorarios.Add(integrante);
                }
                else
                {
                    _context.Entry(integrante).State = EntityState.Modified;
                }
            }
            foreach (var detalle in detallesEliminados)
            {
                _context.detalleshorarios.Remove(detalle);
            }
            foreach (var integrante in integrantesEliminados)
            {
                _context.integranteshorarios.Remove(integrante);
            }

            try
            {               
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorarioExists(id))
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

        // POST: api/ApiHorarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Horario>> PostHorario(Horario horario)
        {
            _context.horarios.Add(horario);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHorario", new { id = horario.Id }, horario);
        }

        // DELETE: api/ApiHorarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHorario(int id)
        {
            var horario = await _context.horarios.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }

            horario.Eliminado = true;
            _context.horarios.Update(horario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorarioExists(int id)
        {
            return _context.horarios.Any(e => e.Id == id);
        }
    }
}
