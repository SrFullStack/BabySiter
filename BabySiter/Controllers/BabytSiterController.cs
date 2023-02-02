using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BabySiter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabytSiterController : ControllerBase
    {
        private readonly IBabysiterService _IBabysiterService;
        public BabytSiterController(IBabysiterService IBabysiterService)
        {
            _IBabysiterService = IBabysiterService;
        }
        // GET: api/<BabytSiterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BabytSiterController>/5
        [HttpGet("{id}")]
       async public Task<ActionResult<Babysiter>> Get([FromQuery] string Password, [FromQuery] string Email)
        {
            Babysiter babysiter = await _IBabysiterService.Get(Password, Email);
            if(babysiter!=null)
            {
                return Ok(babysiter);
            }
            return (NoContent());
        }

        // POST api/<BabytSiterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BabytSiterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BabytSiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
