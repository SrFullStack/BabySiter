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
    public class TimeController : ControllerBase
    {
        private readonly ITimeService _ITimeService;

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
        //async public Task<ActionResult<Time>> Get( int BabysiterId)
        //{
        //    Time time = await _ITimeService.Get(BabysiterId);
        //    if (time != null)
        //    {
        //        //SearchBabySiterDTO searchBabySiterDTO = _mapper.Map<SearchBabysiter, SearchBabySiterDTO>(searchBabysiter);
        //        return Ok(time);

        //    }
        //    return (NoContent());
        //}

        async public Task<ActionResult<TimeDTO>> Get(int BabysiterId)
        {
            Time time = await _ITimeService.Get(BabysiterId);
            if (time != null)
            {
                TimeDTO timedto = _mapper.Map<Time, TimeDTO>(time);

                return Ok(timedto);
            }
            return (NoContent());
        }
        // POST api/<TimeController>
        [HttpPost]
        public ActionResult<Time> Post([FromBody] TimeDTO TimeDTO)
        {
            Time time = _mapper.Map<TimeDTO, Time>(TimeDTO);
            if (_ITimeService.Insert(time) != null)
            {
                //
                return time;
            }
            return StatusCode(204);
        }


        // PUT api/<TimeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Time time)
        {

            //Babysiter babysiter = _mapper.Map<BabySiterDTO, Babysiter>(siterDTO);
            _ITimeService.put(id, time);

        }
        // DELETE api/<TimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}