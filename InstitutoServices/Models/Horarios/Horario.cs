using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Models.Horarios
{
    public class Horario
    {
        public int Id { get; set; }
        public int? MateriaId { get; set; }
        public Materia? Materia { get; set; } = null;
        public int CantidadHoras { get; set; } = 0;
        public int? CicloLectivoId { get; set; }
        public CicloLectivo? CicloLectivo { get; set; }
        public bool Eliminado { get; set; } = false;


        public ICollection<DetalleHorario>? DetallesHorario { get; set; }

        public ICollection<IntegranteHorario>? IntegrantesHorario { get; set; }

        public override string ToString()
        {
            var docentes = string.Join(", ", IntegrantesHorario.Select(x => x.Docente?.Nombre));
            return $"{Materia?.Nombre} {docentes}" ?? string.Empty;
        }
        public Horario()
        {
            DetallesHorario = new List<DetalleHorario>();
            IntegrantesHorario = new List<IntegranteHorario>();
        }
    }
}
