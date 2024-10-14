using InstitutoServices.Models;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Interfaces.Commons
{
    public interface IUsuarioService : IGenericService<Usuario>
    {
        public Task<Usuario?> GetUserByEmail(string? email);
        public Task<Usuario?> GetUserByDocente(int? docenteId);
    }
}
