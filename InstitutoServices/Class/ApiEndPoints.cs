namespace InstitutoServices.Class
{
    public static class ApiEndpoints
    {
        public static string Carrera { get; set; } = "apicarreras";
        public static string Alumno { get; set; } = "apialumnos";
        public static string AnioCarrera { get; set; } = "apianiocarreras";
        public static string Materia { get; set; } = "apimaterias";
        public static string Inscripcion { get; set; } = "apiinscripciones";
        public static string DetalleInscripcion { get; set; } = "apidetalleinscripciones";
        public static string CicloLectivo { get; set; } = "apicicloslectivos";
        public static string TurnoExamen { get; set; } = "apiturnosexamenes";
        public static string Docente { get; set; } = "apidocentes";
        public static string MesaExamen { get; set; } = "apimesasexamenes";
        public static string DetalleMesaExamen { get; set; } = "apidetallesmesasexamenes";
        public static string Hora { get; set; } = "apihoras";
        public static string Horario { get; set; } = "apihorarios";
        public static string DetalleHorario { get; set; } = "apidetalleshorarios";
        public static string Usuario { get; set; } = "apiusuarios";
        public static string InscriptoCarrera { get; set; } = "apiinscriptoscarreras";
        public static string JefaturaSeccion { get; set; } = "apijefaturassecciones";




        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Carrera) => Carrera,
                nameof(Alumno) => Alumno,
                nameof(AnioCarrera) => AnioCarrera,
                nameof(Materia) => Materia,
                nameof(Inscripcion) => Inscripcion,
                nameof(DetalleInscripcion) => DetalleInscripcion,
                nameof(CicloLectivo) => CicloLectivo,
                nameof(TurnoExamen) => TurnoExamen,
                nameof(Docente) => Docente,
                nameof(MesaExamen) => MesaExamen,
                nameof(DetalleMesaExamen) => DetalleMesaExamen,
                nameof(Hora) => Hora,
                nameof(Horario) => Horario,
                nameof(DetalleHorario) => DetalleHorario,
                nameof(Usuario) => Usuario,
                nameof(InscriptoCarrera) => InscriptoCarrera,
                nameof(JefaturaSeccion) => JefaturaSeccion,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
