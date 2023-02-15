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
    public class BabytSiterController : ControllerBase
    {
        private readonly IBabysiterService _IBabysiterService;

        private readonly IMapper _mapper;

        public BabytSiterController(IBabysiterService IBabysiterService, IMapper mapper)
        {
            _IBabysiterService = IBabysiterService;
            _mapper = mapper;

        }
        // GET: api/<BabytSiterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BabytSiterController>/5
        [HttpGet("{id}")]
        //async public Task<ActionResult<BabySiterDTO>> Get([FromQuery] string Password, [FromQuery] string Email)
        //{
        //    Babysiter babysiter = await _IBabysiterService.Get(Password, Email);
        //    if (babysiter != null)
        //    {
        //        BabySiterDTO babySiterdto = _mapper.Map<Babysiter, BabySiterDTO>(babysiter);
        //        //
        //        return Ok(babySiterdto);
        //    }
        //    return (NoContent());
        //}
        async public Task<ActionResult<BabySiterDTO>> Get([FromQuery] string Password, [FromQuery] string Email)
        {
            Babysiter babysiter = await _IBabysiterService.Get(Password, Email);
            if (babysiter != null)
            {
                BabySiterDTO babySiterdto = _mapper.Map<Babysiter, BabySiterDTO>(babysiter);
                //
                return Ok(babySiterdto);
            }
            return (NoContent());
        }

        // POST api/<BabytSiterController>
        [HttpPost]
        public ActionResult<Babysiter> Post([FromBody] BabySiterDTO babysiter)
        {
            Babysiter babysiter1 = _mapper.Map< BabySiterDTO, Babysiter>(babysiter);

            if (_IBabysiterService.Insert(babysiter1) != null)
            {
                return babysiter1;
            }
            return StatusCode(204);
        }

        // PUT api/<BabytSiterController>/5
        [HttpPut("{id}")]
        //public void Put(string id, [FromBody] Babysiter babysiter)
        //{
        //    _IBabysiterService.put(id, babysiter);

        //}

        public void Put(string id, [FromBody] BabySiterDTO babysiter)
        {
            Babysiter babysiter1 = _mapper.Map<BabySiterDTO, Babysiter>(babysiter);
            _IBabysiterService.put(id, babysiter1);

        }
        // DELETE api/<BabytSiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id,[FromBody]Babysiter babysiter)
        {

            _IBabysiterService.Delete(id,babysiter);
        }
    }
}
   