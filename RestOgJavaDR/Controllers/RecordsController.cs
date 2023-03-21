using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RestOgJavaDR.Model;
using RestOgJavaDR.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestOgJavaDR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly RecordsRepository repo = new RecordsRepository();
        // GET: api/<RecordsController>
       

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet]
        public IEnumerable<Records> GetByFilter([FromQuery]string title = null, [FromQuery] string artist = null, [FromQuery] string _sortBy = null)
        {
            return repo.GetAll(title, artist, _sortBy);
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
