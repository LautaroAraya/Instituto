using InstitutoServices.Class;
using InstitutoServices.Interfaces;
using System.Text.Json;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Services.Commons
{
    public class InscriptoCarreraService : GenericService<InscriptoCarrera>, IInscriptoCarreraService
    {
        public InscriptoCarreraService()
        {
        }

        public InscriptoCarreraService(HttpClient client) : base(client)
        {

        }

        public async Task<List<InscriptoCarrera>?> GetByAlumno(int? alumnoId)
        {
            var response = await client.GetAsync($"{_endpoint}/getByAlumno?alumnoId={alumnoId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return JsonSerializer.Deserialize<List<InscriptoCarrera>>(content, options); ;
        }
    }
}
