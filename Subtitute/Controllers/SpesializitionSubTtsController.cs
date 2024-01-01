using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subtitute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpesializitionSubTtsController : ControllerBase
    {
        // GET: api/<SpesializitionSubTtsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SpesializitionSubTtsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SpesializitionSubTtsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SpesializitionSubTtsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SpesializitionSubTtsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
