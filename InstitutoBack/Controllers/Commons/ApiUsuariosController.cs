using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InstitutoServices.Models;
using InstitutoBack.DataContext;
using InstitutoServices.Models.Commons;
using System.Text.RegularExpressions;

namespace InstitutoBack.Controllers.Commons
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiUsuariosController : ControllerBase
    {
        private readonly InstitutoContext _context;

        public ApiUsuariosController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: api/ApiUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Getusuarios()
        {
            return await _context.usuarios.ToListAsync();
        }



        // GET: api/ApiUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpGet("getByEmail")]
        public async Task<ActionResult<Usuario>> GetUserByEmail([FromQuery] string email)
        {
            if (string.IsNullOrWhiteSpace(email)|| !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return BadRequest("no se recibió un email o no es válido.");
            }

            var user = await _context.usuarios.Include(u=>u.Alumno).Include(u=>u.Docente).Where(u=>u.Email.Equals(email)).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            return Ok(user);
        }

        [HttpGet("getByDocente")]
        public async Task<ActionResult<Usuario>> GetUserByDocente([FromQuery] int docenteId)
        {

            var user = await _context.usuarios.Include(u => u.Alumno).Include(u => u.Docente).Where(u => u.DocenteId.Equals(docenteId)).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            return Ok(user);
        }

        // PUT: api/ApiUsuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/ApiUsuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/ApiUsuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Eliminado = true;
            _context.usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.usuarios.Any(e => e.Id == id);
        }
    }
}
