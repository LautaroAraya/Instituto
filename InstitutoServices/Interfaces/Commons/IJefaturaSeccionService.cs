using InstitutoServices.Models;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Interfaces.Commons
{
    public interface IJefaturaSeccionService : IGenericService<JefaturaSeccion>
    {
        public Task<List<JefaturaSeccion>?> GetByDocente(int? docenteId);
    }
}
