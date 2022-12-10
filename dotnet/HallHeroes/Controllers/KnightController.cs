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
    public class KnightController : ControllerBase
    {
        private readonly IDomainApplication _domainApplication;

        private readonly ILogger<KnightController> _logger;

        public KnightController(ILogger<KnightController> logger, IDomainApplication domainApplication)
        {
            _logger = logger;
            _domainApplication = domainApplication;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            try
            {
                return Ok(_domainApplication.GetAllKnights().ToList().Select(k => new KnightModel(k)).ToList());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Bd");
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_domainApplication.GetKnightsFindId(id).ToList().Select(k => new KnightModel(k)).ToList());
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Bd");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Knight knight)
        {
            try
            {
                _domainApplication.AddKnight(knight);
                return this.StatusCode(StatusCodes.Status200OK, "Salvo com Suceso");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Bd");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            try
            {
                var knights = _domainApplication.GetKnightsFindId(id).ToList();
                if (knights.Any())
                {
                    _domainApplication.AddKnight(knights.First());
                    return this.StatusCode(StatusCodes.Status200OK, "Salvo com Suceso");
                }
                return this.StatusCode(StatusCodes.Status404NotFound, "Knigth não localizado");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Bd");
            }

        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var knights = _domainApplication.GetKnightsFindId(id).ToList();
                if (knights.Any())
                {
                    _domainApplication.DeleteKnight(knights.First());
                    return this.StatusCode(StatusCodes.Status200OK, "Excluído com Suceso");
                }
                return this.StatusCode(StatusCodes.Status404NotFound, "Knigth não localizado");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Bd");
            }
        }
    }
}
