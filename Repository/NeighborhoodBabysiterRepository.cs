using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NeighborhoodBabysiterRepository: INeighborhoodBabysiterRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;

        public NeighborhoodBabysiterRepository(DB_BabySiterContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;


        }
        async public Task<NeighborhoodBabysiter[]> Get(int id)
        {
            var userQuery = (from NeighborhoodBabysiter in _DB_BABYSITERContext.NeighborhoodBabysiters
                             where NeighborhoodBabysiter.BabysiterId == id
                             select NeighborhoodBabysiter).ToArray<NeighborhoodBabysiter>();
            return userQuery;



        }

        public async Task<NeighborhoodBabysiter> Insert(NeighborhoodBabysiter neighborhoodBabysiter)
        {
            await _DB_BABYSITERContext.AddAsync(neighborhoodBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return neighborhoodBabysiter;
        }
        public async Task<NeighborhoodBabysiter> put(int id, NeighborhoodBabysiter neighborhoodBabysiter)
        {
            _DB_BABYSITERContext.NeighborhoodBabysiters.Update(neighborhoodBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return neighborhoodBabysiter;
        }
    }
}
