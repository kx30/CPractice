using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Введите число в поисковую строку: values/x" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<double> Get(double id)
        {
            id = Math.Cos(1.5 * id) - Math.Exp(Math.Sin(id + 4.0 / 3.0)) + Math.Sqrt(id + 7.0 / 6.0);
            return id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
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
