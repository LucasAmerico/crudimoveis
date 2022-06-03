using Models.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class ImovelService : IImovelService
    {
        public HttpClient _httpClient;
        public ImovelService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<IEnumerable<Imovel>> GetImoveis()
        {
            var imoveis = await _httpClient.GetFromJsonAsync<IEnumerable<Imovel>>($"imoveis");
            return imoveis;
        }
        public async Task<Imovel> GetImovel(int id)
        {
            var imovel = await _httpClient.GetFromJsonAsync<Imovel>($"imoveis/{id}");
            return imovel;
        }
        public async Task<Imovel> CreateImovel(Imovel novoImovel)
        {
            var response = await _httpClient.PostAsJsonAsync<Imovel>($"imoveis", novoImovel);
            var content = await response.Content.ReadFromJsonAsync<Imovel>();
            return content;
        }
        public async Task<Imovel> UpdateImovel(Imovel imovel)
        {
            var response = await _httpClient.PutAsJsonAsync<Imovel>($"imoveis/{imovel.Id}", imovel);
            var content = await response.Content.ReadFromJsonAsync<Imovel>();
            return content;
        }
        public async Task DeleteImovel(int id)
        {
            await _httpClient.DeleteAsync($"imoveis/{id}");
        }
    }
}
