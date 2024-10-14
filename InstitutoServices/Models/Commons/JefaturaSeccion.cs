namespace InstitutoServices.Models.Commons
{
    public class JefaturaSeccion
    {
        public int Id { get; set; }
        public int? DocenteId { get; set; }
        public Docente? Docente { get; set; } = null;
        public int? CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Docente?.Nombre} {Carrera?.Nombre}" ?? string.Empty;
        }
    }
}
