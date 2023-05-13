using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class NeighborhoodService : INeighborhoodService


    {
        private readonly INeighborhoodRepository _INeighborhoodRepository;
        public NeighborhoodService(INeighborhoodRepository INeighborhoodRepository)
        {
            _INeighborhoodRepository = INeighborhoodRepository;
        }
        public async Task<Neighborhood[]> Get()
        {

            {
                return await _INeighborhoodRepository.Get();

            }

        }
    }
}




