using InstitutoServices.Class;
using InstitutoServices.Interfaces;
using System.Text.Json;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Services.Commons
{
    public class JefaturaSeccionService : GenericService<JefaturaSeccion>, IJefaturaSeccionService
    {
        public JefaturaSeccionService()
        {
        }

        public JefaturaSeccionService(HttpClient client) : base(client)
        {

        }

        public async Task<List<JefaturaSeccion>?> GetByDocente(int? docenteId)
        {
            var response = await client.GetAsync($"{_endpoint}/getByDocente?docenteId={docenteId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return JsonSerializer.Deserialize<List<JefaturaSeccion>>(content, options); ;
        }
    }
}
