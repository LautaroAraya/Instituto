using InstitutoServices.Class;
using InstitutoServices.Interfaces;
using System.Text.Json;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Services.Commons
{
    public class UsuarioService : GenericService<Usuario>, IUsuarioService
    {
        public UsuarioService()
        {
        }

        public UsuarioService(HttpClient client) : base(client)
        {

        }

        
        public async Task<Usuario?> GetUserByEmail(string? email)
        {
            var response = await client.GetAsync($"{_endpoint}/getByEmail?email={email}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return JsonSerializer.Deserialize<Usuario>(content, options); ;
        }

        public async Task<Usuario?> GetUserByDocente(int? docenteId)
        {
            var response = await client.GetAsync($"{_endpoint}/getByDocente?docenteId={docenteId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return JsonSerializer.Deserialize<Usuario>(content, options); ;
        }
    }
}
