using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTFul_SMN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissoesController : ControllerBase
    {


        // GET api/profissoes
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "profissoes get" };
            
           
            
        }

        // GET api/profissoes/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            return "profissoes get " + id;
        }

        // POST api/profissoes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/profissoes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/profissoes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
