using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class NeighborhoodBabysiterService: INeighborhoodBabysiterService
    {

        private readonly INeighborhoodBabysiterRepository _neighborhoodBabysiterRepository ;
        public NeighborhoodBabysiterService(INeighborhoodBabysiterRepository INeighborhoodBabysiterRepository)
        {
            _neighborhoodBabysiterRepository = INeighborhoodBabysiterRepository;
        }
        async public Task<NeighborhoodBabysiter> Get(int id)
        {
            {

                return await _neighborhoodBabysiterRepository.Get(id);


            }
        }
        public async Task<NeighborhoodBabysiter> Insert(NeighborhoodBabysiter neighborhoodBabysiter)
        {
            NeighborhoodBabysiter neighborhoodBabysiter1 = await _neighborhoodBabysiterRepository.Insert(neighborhoodBabysiter);
            if (neighborhoodBabysiter1 != null)
            {
                return neighborhoodBabysiter1;
            }
            return null;
        }
        public void put(int id, NeighborhoodBabysiter neighborhoodBabysiter)
        {
            _neighborhoodBabysiterRepository.put(id, neighborhoodBabysiter);


        }
    }
}
