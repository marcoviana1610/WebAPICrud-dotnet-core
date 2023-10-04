using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICrud.DataContext;
using WebAPICrud.Models;
using WebAPICrud.Service.FuncionarioService;

namespace WebAPICrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private readonly IFuncionarioInterface _funcionarioInterface;
        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;
        }


        // ------------------------- GET -------------------------

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios() 
        {
            return Ok( await _funcionarioInterface.GetFuncionarios()); // Executando a funcao GetFuncionarios da FuncionarioService.cs 
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionarioById(int id)
        {
            return Ok( await _funcionarioInterface.GetFuncionarioById(id));
        }



        // ------------------------- POST -------------------------
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario)); // IFuncionarioInterface.MetodoCriarFuncionario(recebefuncionario);
        }




        // ------------------------- PUT -------------------------
        [HttpPut("inativaFuncionario")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> InativaFuncionario(int id)
        {
            return Ok(await _funcionarioInterface.InativaFuncionario(id));
        }


        [HttpPut]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            return Ok(await _funcionarioInterface.UpdateFuncionario(editadoFuncionario));
        }


        // ------------------------- DELETE -------------------------
        [HttpDelete("deleteFuncionario")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            return Ok(await _funcionarioInterface.DeleteFuncionario(id));
        }
    }
}

