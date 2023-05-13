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
    public class NeighborhoodController : ControllerBase
    {
        private readonly INeighborhoodService _INeighborhoodService;


        public NeighborhoodController(INeighborhoodService INeighborhoodService)
        {
            _INeighborhoodService = INeighborhoodService;
      
        }



        // GET: api/<NeighborhoodController>
        [HttpGet]
        public async Task<Neighborhood[]> Get()
        {
            Neighborhood[] neighborhoods = await _INeighborhoodService.Get();
            return neighborhoods;
        }

        // GET api/<NeighborhoodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NeighborhoodController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NeighborhoodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NeighborhoodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
