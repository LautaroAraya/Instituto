using InstitutoServices.Interfaces.MesasExamenes;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstitutoServices.Models.Horarios
{
    public class Hora
    {
        public int Id { get; set; }
        
        [NotMapped]
        public string Nombre
        {
            get { return EsRecreo?"Recreo":""+
                    $"{Desde.Hour}:" +
                    $"{Desde.Minute} - " +
                    $"{Hasta.Hour}:" +
                    $"{Hasta.Minute}"; }
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
