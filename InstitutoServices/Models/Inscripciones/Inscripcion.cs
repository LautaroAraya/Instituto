﻿using InstitutoServices.Models.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstitutoServices.Models.Inscripciones
{
    public class Inscripcion
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }
        public int AlumnoId { get; set; }
        public Alumno? Alumno { get; set; }
        public int CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
        public int CicloLectivoId { get; set; }
        public CicloLectivo? CicloLectivo { get; set; }
        public bool Eliminado { get; set; } = false;


        [NotMapped]
        public string? Inscripto
        {
            get { return $"{Alumno?.ApellidoNombre} - {Carrera?.Nombre}" ?? string.Empty; }
        }
    }
}
