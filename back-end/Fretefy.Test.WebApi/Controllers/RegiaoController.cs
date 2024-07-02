using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.WebApi.EntityBuilder;
using Fretefy.Test.WebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fretefy.Test.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegiaoController : Controller
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var regioes = _regiaoService.Get();
            var regiaoViewModel = RegiaoBuilder.BuildViews(regioes);
            return Ok(regiaoViewModel);
        }

        [HttpPost]
        public IActionResult Post(RegiaoViewModel regiao)
        {
            var entity = RegiaoBuilder.Builder(regiao);
            try
            {
                _regiaoService.AddRegiao(entity).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(RegiaoViewModel regiao)
        {
            var entity = RegiaoBuilder.Builder(regiao);
            try
            {
                _regiaoService.UpdateRegiao(entity).GetAwaiter().GetResult();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
