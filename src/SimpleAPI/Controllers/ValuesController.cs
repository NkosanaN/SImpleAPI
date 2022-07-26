using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Sthe Ndlela 456<br/>";
        }

        // POST: api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
}
