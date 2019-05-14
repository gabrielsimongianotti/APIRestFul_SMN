using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model.Context;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTFul_SMN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {


        // GET api/funcionarios
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            SQLContext sql = new SQLContext();
            
            return new string[] { "oi"};
            
        }

        // GET api/funcionarios/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            return "get "+id;
        }

        // POST api/funcionarios
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/funcionarios/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
