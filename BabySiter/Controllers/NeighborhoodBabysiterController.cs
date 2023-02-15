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
    public class NeighborhoodBabysiterController : ControllerBase
    {
        private readonly INeighborhoodBabysiterService _INeighborhoodBabysiterService;

        private readonly IMapper _mapper;

        public NeighborhoodBabysiterController(INeighborhoodBabysiterService INeighborhoodBabysiterService, IMapper mapper)
        {
            _INeighborhoodBabysiterService = INeighborhoodBabysiterService;
            _mapper = mapper;

        }
        // GET: api/<NeighborhoodBabysiterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NeighborhoodBabysiterController>/5
        [HttpGet("{id}")]
        async public Task<ActionResult<NeighborhoodBabysiter>> Get([FromQuery] int id)
        {
            NeighborhoodBabysiter neighborhoodBabysiter = await _INeighborhoodBabysiterService.Get(id);
            if (neighborhoodBabysiter != null)
            {
                NeighborhoodBabysiterDTO neighborhoodBabysiterDTO = _mapper.Map<NeighborhoodBabysiter, NeighborhoodBabysiterDTO>(neighborhoodBabysiter);
                //
                return Ok(neighborhoodBabysiterDTO);
            }
            return (NoContent());
        }

        // POST api/<NeighborhoodBabysiterController>
        [HttpPost]
        public ActionResult<NeighborhoodBabysiter> Post([FromBody] NeighborhoodBabysiterDTO neighborhoodBabysiterDTO)
        {
            NeighborhoodBabysiter neighborhoodBabysiter = _mapper.Map<NeighborhoodBabysiterDTO, NeighborhoodBabysiter>(neighborhoodBabysiterDTO);
            if (_INeighborhoodBabysiterService.Insert(neighborhoodBabysiter) != null)
            {

                return neighborhoodBabysiter;
            }
            return StatusCode(204);
        }


        // PUT api/<NeighborhoodBabysiterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NeighborhoodBabysiterDTO neighborhoodBabysiterDTO)
        {
            NeighborhoodBabysiter neighborhoodBabysiter = _mapper.Map<NeighborhoodBabysiterDTO, NeighborhoodBabysiter>(neighborhoodBabysiterDTO);

            _INeighborhoodBabysiterService.put(id,neighborhoodBabysiter);

        }
        // DELETE api/<NeighborhoodBabysiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
