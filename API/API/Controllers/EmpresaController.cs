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
    public class EmpresaController : ControllerBase
    {


        // GET api/empresa
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "get" };
            
           
            
        }

        // GET api/empresa/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            return "get "+id;
        }

        // POST api/empresa
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/empresa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/empresa/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
