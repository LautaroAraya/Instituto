using InstitutoServices.Models;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Interfaces.Commons
{
    public interface IInscriptoCarreraService : IGenericService<InscriptoCarrera>
    {
        public Task<List<InscriptoCarrera>?> GetByAlumno(int? alumnoId);
    }
}
