using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model;
using API_RESTFul_SMN.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTFul_SMN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependentesController : ControllerBase
    {
        private IDependentesService _dependentesService;
            public DependentesController(IDependentesService dependentesService)
        {
            _dependentesService = dependentesService;
        }

        // GET api/dependentes
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_dependentesService.FindAll());
        }

        // GET api/dependentes/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var dependentes = _dependentesService.FindById(id);
            if (dependentes == null) return NotFound();
            return Ok(dependentes);

        }

        // POST api/dependentes
        [HttpPost]
        public ActionResult Post([FromBody] Dependentes dependentes)
        {
            if (dependentes == null) return BadRequest();
            return new ObjectResult(_dependentesService.Create(dependentes));
        }

        // PUT api/dependentes/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Dependentes dependentes)
        {
            if (dependentes == null) return BadRequest();
            return new ObjectResult(_dependentesService.Update(dependentes));
        }

        // DELETE api/dependentes/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _dependentesService.Delete(id);
            return NoContent();
        }
    }
}
