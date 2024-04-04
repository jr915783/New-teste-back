using Data.Context;
using Domain.Entities;
using Repositories.Interface;

namespace Repositories.Repository
{
    public class VagaRepository : IVaga
    {
        public readonly DataContext _dataContex;

        
        public VagaRepository(DataContext dataContex)
        {
            _dataContex = dataContex;
        }        

        public async  Task<Vaga[]> BuscarVagas(string[] filtro)
        {

            if (filtro.Count() == 0 || filtro == null)
            {
                return _dataContex.Vaga.ToArray();
            }
            else
            {
                List<Vaga> vagasRetorno = new List<Vaga>();
                List<Vaga> vagas = new List<Vaga>();

                for (int i = 0; i < filtro.Length; i++)
                {
                    vagas = _dataContex.Vaga.Where(x => x.Languages.Contains(filtro[i])).ToList();
                    for (int y = 0; y < vagas.Count; y++)
                    {
                        vagasRetorno.Add(vagas[y]);
                    }
                }
                return vagasRetorno.ToArray();
            }
            
        }       

        public async Task<Vaga> Insert(Vaga entity)
        {          
             _dataContex.Vaga.AddAsync(entity);
            await _dataContex.SaveChangesAsync();
            return entity;
        }

       
    }
}
