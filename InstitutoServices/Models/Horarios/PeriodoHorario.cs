﻿using InstitutoServices.Interfaces;
using InstitutoServices.Models.Inscripciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Models.Horarios
{
    public class PeriodoHorario: IEntityWithId
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Actual { get; set; } = false;
        public int? CicloLectivoId { get; set; }
        public CicloLectivo? CicloLectivo { get; set; }
        public bool Es2doCuatrimestre { get; set; } = false;
        public bool Eliminado { get; set; } = false;
    }
}
