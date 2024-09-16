﻿using InstitutoServices.Enums;

namespace InstitutoServices.Models.Horarios
{
    public class DetalleHorario
    {
        public int Id { get; set; }
        public int? HorarioId { get; set; }
        public Horario? Horario { get; set; } = null;
        public DiaEnum Dia { get; set; } = 0;
        public int? HoraId { get; set; }
        public Hora? Hora { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Dia} {Hora?.Nombre} {Horario?.Materia?.Nombre}" ?? string.Empty;
        }
    }
}
