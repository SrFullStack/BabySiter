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
        public async Task<ActionResult<RequsetSearchBabysiter>> Post([FromBody] RequsetSearchBabysiterDTO RequsetSearchBabysiterDTO)
        {
            RequsetSearchBabysiter RequsetSearchBabysiter = _mapper.Map<RequsetSearchBabysiterDTO, RequsetSearchBabysiter>(RequsetSearchBabysiterDTO);
            var result = await _IRequsetSearchBabysiterService.Insert(RequsetSearchBabysiter);
            if (result != null)
            {
                return RequsetSearchBabysiter;
            }
            return StatusCode(204);
        }


        //public async Task<ActionResult<RequsetSearchBabysiter>> Post([FromBody] RequsetSearchBabysiterDTO RequsetSearchBabysiterDTO)
        //{RequsetSearchBabysiter
        //    RequsetSearchBabysiter RequsetSearchBabysiter = _mapper.Map<RequsetSearchBabysiterDTO, RequsetSearchBabysiter>(RequsetSearchBabysiterDTO);
        //    var result = await _IRequsetSearchBabysiterService.Insert(RequsetSearchBabysiter);
        //    if (result != null)
        //    {
        //        return RequsetSearchBabysiter;
        //    }
        //    return StatusCode(204);
        //}


        // PUT api/<RequsetSearchBabysiterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RequsetSearchBabysiter requsetSearchBabysiter)
        {
            _IRequsetSearchBabysiterService.put(id, requsetSearchBabysiter);

        }
        [HttpGet, Route("GetEmail")]
        public Task GetEmail([FromQuery] string email)
        {
            return _IRequsetSearchBabysiterService.GetEmail(email);
        }
        // DELETE api/<RequsetSearchBabysiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}




