using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomaController : ControllerBase
    {
        //tiagoraujo
        [HttpPost]
        public Retorno Post([FromBody] Aritimetica obj)
        {
            return new Retorno(obj.Soma());
        }
    }
}