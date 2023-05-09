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
    public class BabySiterController : ControllerBase
    {
        private readonly IBabysiterService _IBabysiterService;

        private readonly IMapper _mapper;

        public BabySiterController(IBabysiterService IBabysiterService, IMapper mapper)
        {
            _IBabysiterService = IBabysiterService;
            _mapper = mapper;

        }
        // GET: api/<BabytSiterController>
        [HttpGet, Route("GetAll")]
        public async Task<BabySiterDTO[]> GetAll()
        {
            Babysiter[] babysiters = await _IBabysiterService.GetAll();
            BabySiterDTO[] res = _mapper.Map<Babysiter[], BabySiterDTO[]>(babysiters);
            return res;
        }



        // GET api/<BabytSiterController>/5
        [HttpGet, Route("Get")]
     
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

        [HttpGet, Route("GetByEmail")]

        async public Task<ActionResult<BabySiterDTO>> GetByEmail( [FromQuery] string Email)
        {
            Babysiter babysiter = await _IBabysiterService.GetByEmail( Email);
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

        //public void Put(string id, [FromBody] Babysiter babysiter)
        //{
        //    _IBabysiterService.put(id, babysiter);

        //}
        [HttpPut, Route("Put")]
        public void Put(string id, [FromBody] BabySiterDTO babysiter)
        {
            Babysiter babysiter1 = _mapper.Map<BabySiterDTO, Babysiter>(babysiter);
            _IBabysiterService.put(id, babysiter1);
           

        }
        // DELETE api/<BabytSiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _IBabysiterService.Delete(id);
        }
        //public ActionResult<Babysiter> Mail([FromBody] RequsetSearchBabysiter requsetSearchBabysiter)
        //{
            
        //    if (_IBabysiterService.Mail(requsetSearchBabysiter) != null)
        //    {
        //        Babysiter babySiter = _IBabysiterService.Mail(requsetSearchBabysiter);
        //        return babySiter ;
        //    }
        //    return StatusCode(204);
        //}
    }
}
   