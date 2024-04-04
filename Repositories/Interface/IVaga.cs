using Domain.Entities;
using Repositories.Base;

namespace Repositories.Interface
{
    public interface IVaga
    {
        Task<Vaga> Insert(Vaga entity);        

        Task<Vaga[]> BuscarVagas(string[] filtro);
        
    }

    
}
