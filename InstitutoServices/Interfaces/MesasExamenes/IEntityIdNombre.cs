namespace InstitutoServices.Interfaces.MesasExamenes
{
    public interface IEntityIdNombre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Eliminado { get; set; }
    }
}
