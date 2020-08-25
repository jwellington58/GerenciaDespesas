using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteMobills.Models;
using TesteMobills.Services;

namespace TesteMobills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        public readonly ConsultaService _service;
        public ConsultasController(Context context)
        {
            this._service = new ConsultaService(context);
        }
        [HttpGet("saldo")]
        public IActionResult Soma()
        {
            return Ok(this._service.ConsultarSaldo());
        }
    }
}
