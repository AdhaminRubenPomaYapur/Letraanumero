using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Numeroaletra.Helpers;

namespace Numeroaletra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase{
        [HttpGet]
        public string LiteralGet(int numero) {
            return Conversores.NumeroALetras(numero);
        }

        public int LiteralGet()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public string LiteralPost([FromHeader]int numero)
        {
            return Conversores.NumeroALetras(numero);
        }
    }
}
