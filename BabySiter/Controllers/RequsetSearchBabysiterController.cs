using AutoMapper;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BabySiter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequsetSearchBabysiterController : ControllerBase
    {
        private readonly IRequsetSearchBabysiterService _IRequsetSearchBabysiterService;

        private readonly IMapper _mapper;

        public RequsetSearchBabysiterController(IRequsetSearchBabysiterService IRequsetSearchBabysiterService, IMapper mapper)
        {
            _IRequsetSearchBabysiterService = IRequsetSearchBabysiterService;
            _mapper = mapper;

        }
        // GET: api/<RequsetSearchBabysiterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RequsetSearchBabysiterController>/5
        [HttpGet("{id}")]
        async public Task<ActionResult<RequsetSearchBabysiterDTO>> Get([FromQuery] int id)
        {
            RequsetSearchBabysiter requsetSearchBabysiter = await _IRequsetSearchBabysiterService.GetRequsetSearchBabysiter(id);
            if (requsetSearchBabysiter != null)
            {
                RequsetSearchBabysiterDTO requsetSearchBabysiterDTO = _mapper.Map<RequsetSearchBabysiter, RequsetSearchBabysiterDTO>(requsetSearchBabysiter);
                //
                return Ok(requsetSearchBabysiterDTO);
            }
            return (NoContent());
        }

        // POST api/<RequsetSearchBabysiterController>
        [HttpPost]
        public ActionResult<RequsetSearchBabysiter> Post([FromBody] RequsetSearchBabysiter requsetSearchBabysiter)
        {
            if (_IRequsetSearchBabysiterService.Insert(requsetSearchBabysiter) != null)
            {
                //BabySiterDTO babySiterdto = _mapper.Map<Babysiter, BabySiterDTO>(babysiter);
                return requsetSearchBabysiter;
            }
            return StatusCode(204);
        }
    

        // PUT api/<RequsetSearchBabysiterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RequsetSearchBabysiter requsetSearchBabysiter)
        {
            _IRequsetSearchBabysiterService.put(id, requsetSearchBabysiter);

        }

        // DELETE api/<RequsetSearchBabysiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
