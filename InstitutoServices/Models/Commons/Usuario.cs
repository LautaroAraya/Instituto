using InstitutoServices.Enums;

namespace InstitutoServices.Models.Commons
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public int? AlumnoId { get; set; }
        public Alumno? Alumno { get; set; } = null;
        public int? DocenteId { get; set; }
        public Docente? Docente { get; set; } = null;
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Alumno?.ApellidoNombre} {Docente?.Nombre}" ?? string.Empty;
        }
    }
}
