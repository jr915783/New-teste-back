using Data.Context;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interface;

namespace TesteCrud.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class VagaController : ControllerBase
    {
        private readonly IVaga _vaga;        

        public VagaController(IVaga vaga, DataContext dataContex)
        {
            _vaga = vaga;           
        }

        [HttpPost("AdicionarVaga")]
        public async Task<IActionResult> AddVaga(Vaga vaga)
        {
            try
            {
                if (vaga == null)
                {
                    return BadRequest($"Não Foi possível adicionar a vaga {vaga} !");
                }
               var vagaReturn =  await _vaga.Insert(vaga);
                return Ok(vagaReturn);
                      
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
        }      

        [HttpPost("BuscarVagas")]
        public async Task<IActionResult> BuscarVagas(string[] filtro)
        {
            var result = await _vaga.BuscarVagas(filtro);           
            return Ok(result.ToList());
        }       
    }
}
