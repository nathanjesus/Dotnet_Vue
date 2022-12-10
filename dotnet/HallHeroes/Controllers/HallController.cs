using Domian;
using DataCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HallHeroes.Models;
using Microsoft.AspNetCore.Http;

namespace HallHeroes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HallController : ControllerBase
    {
        private readonly IDomainApplication _domainApplication;

        private readonly ILogger<KnightController> _logger;

        public HallController(ILogger<KnightController> logger, IDomainApplication domainApplication)
        {
            _logger = logger;
            _domainApplication = domainApplication;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            try
            {
                return Ok(_domainApplication.GetAllHall().Select(k => new KnightModel(k.Knight)).ToList());
                
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Bd");
            }
        }
    }
}
