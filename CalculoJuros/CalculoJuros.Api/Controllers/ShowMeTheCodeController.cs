using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET: api/ShowMeTheCode/5
        [HttpGet]
        public string Get()
        {
            return "https://github.com/Cordeiro96/Desafio-SoftPlan";
        }
    }
}
