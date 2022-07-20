using Microsoft.AspNetCore.Mvc;
using Heroes.Domain.Dto.Requisicoes.Heroes.Requests;
using Heroes.Application.Interfaces.Hero;

namespace Heroes.Api.Controller.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HeroController : ControllerBase
    {

        private IHeroAppService _service { get; set; }

        public HeroController(
            IHeroAppService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Registra([FromBody] RegistrarHeroRequest request)
        {
            return Ok(_service.Registrar(request));
        }

        //[HttpGet]
        //public IActionResult Todos()
        //{
        //    return Ok();
        //}

        //[HttpGet("{id}")]
        //public IActionResult Busca([FromRoute] int id)
        //{
        //    return Ok(id);
        //}

        //[HttpPut]
        //public IActionResult Edita()
        //{
        //    return Ok();
        //}

        //[HttpDelete]
        //public IActionResult Exclui()
        //{
        //    return Ok();
        //}

    }
}
