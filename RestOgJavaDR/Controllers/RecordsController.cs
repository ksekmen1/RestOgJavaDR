using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RestOgJavaDR.Models;
using RestOgJavaDR.Repository;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestOgJavaDR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private IRecordsRepository _repository;

        public RecordsController(IRecordsRepository repository)
        {
            _repository = repository;
        }
        // GET: api/<RecordsController>
       

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [ProducesResponseType (StatusCodes.Status200OK)]
        [HttpGet]
        public ActionResult<IEnumerable<Records>> GetByFilter([FromQuery]string title = null, [FromQuery] string artist = null, [FromQuery] string _sortBy = null)
        {
            IEnumerable<Records>records = _repository.GetAll(title, artist, _sortBy);
            
            return Ok(records);
        }

        // POST api/<RecordsController>
        /*[HttpPost]
        public ActionResult<Records> Post([FromBody] Records value)
        {
            try
            {
                Records newRecords = repo.Add(value);
                string uri = Url.RouteUrl(RouteData.Values) + "/" + newRecords.title;
                return Created(uri, newRecords);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } */

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
