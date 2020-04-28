using System;
using CalculoJuros.Aplicacao.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculoJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoJurosController : ControllerBase
    {
        private readonly ICalculoJurosAplicacao _app;

        public CalculoJurosController(ICalculoJurosAplicacao app)
        {
            _app = app;
        }

        // GET: api/CalculoJuros
        [HttpGet]
        public ActionResult<decimal> Get(decimal? valorInicial, int? meses)
        {
            if (valorInicial == null || meses == null)
                return NoContent();

            return Ok(_app.ObterCalculoJuros(Convert.ToDecimal(valorInicial), Convert.ToInt32(meses)));
        }
    }
}