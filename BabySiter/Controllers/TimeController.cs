using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BabySiter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly  ITimeService _ITimeService;

        private readonly IMapper _mapper;

        public TimeController(ITimeService ITimeService, IMapper mapper)
        {
            _ITimeService = ITimeService;
            _mapper = mapper;




        }
        // GET: api/<TimeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TimeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TimeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TimeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
