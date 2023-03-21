using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RestOgJavaDR.Model;
using RestOgJavaDR.Repository;
using Microsoft.AspNetCore.Http;

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

        [ProducesResponseType (StatusCodes.Status404NotFound)]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [HttpGet]
        public IEnumerable<Records> GetByFilter([FromQuery]string title = null, [FromQuery] string artist = null, [FromQuery] string _sortBy = null)
        {
            Records record = repo.GetAll(title, artist, _sortBy);
            if (record == null) return NotFound("Couldnt find result");
            
            return Ok(record);
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
