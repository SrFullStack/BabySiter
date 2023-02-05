﻿using AutoMapper;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BabySiter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchBabySiterController : ControllerBase
        
    {
        private readonly ISearchBabySiterService _ISearchBabySiterService;
        private readonly IMapper _mapper;

        public SearchBabySiterController(ISearchBabySiterService ISearchBabySiterService,IMapper mapper)
        {
            _ISearchBabySiterService = ISearchBabySiterService;
            _mapper= mapper;    
        }

        // GET: api/<SearchBabySiterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SearchBabySiterController>/5
        [HttpGet("{id}")]
        async public  Task<ActionResult<SearchBabySiterDTO>> Get([FromQuery] string password, [FromQuery] string email) {
            SearchBabysiter searchBabysiter = await _ISearchBabySiterService.Get(password, email);
                if (searchBabysiter != null)
            {
                SearchBabySiterDTO searchBabySiterDTO = _mapper.Map<SearchBabysiter, SearchBabySiterDTO>(searchBabysiter);
                return Ok(searchBabySiterDTO);

            }
return (NoContent());




        }
// POST api/<SearchBabySiterController>
[HttpPost]
        public ActionResult<SearchBabysiter> Post([FromBody] SearchBabysiter searchBabysiter)
        {
            if (_ISearchBabySiterService.Insert(searchBabysiter) != null)
            {
                //BabySiterDTO babySiterdto = _mapper.Map<Babysiter, BabySiterDTO>(babysiter);
                return searchBabysiter;
            }
            return StatusCode(204);
        }


        // PUT api/<SearchBabySiterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SearchBabysiter searchBabysiter)
        {
            _ISearchBabySiterService.put(id, searchBabysiter);

        }
     

        // DELETE api/<SearchBabySiterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
