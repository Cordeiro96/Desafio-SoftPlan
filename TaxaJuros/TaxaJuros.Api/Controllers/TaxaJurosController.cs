using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxaJuros.Aplicacao.Interface;

namespace TaxaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAplicacao _app;

        public TaxaJurosController(ITaxaJurosAplicacao app)
        {
            _app = app;
        }

        // GET: api/Juros
        [HttpGet]
        public ActionResult<int> Get()
        {
            return Ok(_app.ObterTaxaDeJuros());
        }
    }
}
