using System;
using System.Collections.Generic;
using System.Data;
using API_RESTFul_SMN.Model;
using API_RESTFul_SMN.Services;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTFul_SMN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoCivilController : ControllerBase
    {
        private IEstadoCivilService _estadoCivilService;

        public EstadoCivilController(IEstadoCivilService estadoCivilServicec)
        {
            _estadoCivilService = estadoCivilServicec;
        }

        // GET api/estadocivil
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_estadoCivilService.FindAll());
        }

        // GET api/estadocivil/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            return "get "+id;
        }

        // POST api/estadocivil
        [HttpPost]
        public ActionResult Post([FromBody] EstadoCivil estadoCivil)
        {
            if (estadoCivil == null) return BadRequest();
            return new ObjectResult(_estadoCivilService.Create(estadoCivil));
        }

        // PUT api/estadocivil/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/estadocivil/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
