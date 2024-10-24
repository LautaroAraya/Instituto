﻿using InstitutoServices.Interfaces.MesasExamenes;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstitutoServices.Models.Horarios
{
    public class Hora
    {
        public int Id { get; set; }
        
        [NotMapped]
        public string Nombre
        {
            get {
                var recreo = EsRecreo ? "Recreo" : "";
                return $"{recreo}{Desde.Hour:D2}:" +
                    $"{Desde.Minute:D2} - " +
                    $"{Hasta.Hour:D2}:" +
                    $"{Hasta.Minute:D2}"; }
        }

        public DateTime Desde { get; set; } = DateTime.MinValue;
        public DateTime Hasta { get; set; } = DateTime.MinValue;
        
        [NotMapped]
        public string Nombre
        {
            get {
                var recreo = EsRecreo ? "Recreo" : "";
                return $"{recreo}{Desde.Hour:D2}:" +
                    $"{Desde.Minute:D2} - " +
                    $"{Hasta.Hour:D2}:" +
                    $"{Hasta.Minute:D2}"; }
        }

        public DateTime Desde { get; set; } = DateTime.MinValue;
        public DateTime Hasta { get; set; } = DateTime.MinValue;
        public bool EsRecreo { get; set; } = false;
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return Nombre;
        }
    }
}
