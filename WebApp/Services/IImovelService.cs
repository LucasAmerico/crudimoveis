using Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IImovelService
    {
        Task<IEnumerable<Imovel>> GetImoveis();
        Task<Imovel> GetImovel(int id);
        Task<Imovel> UpdateImovel(Imovel imovel);
        Task<Imovel> CreateImovel(Imovel novoImovel);
        Task DeleteImovel(int id);
    }
}
