using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

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
        public  IActionResult Get()
        {
            var regioes = _regiaoService.Get();
            return Ok(regioes);
        }
    }
}
