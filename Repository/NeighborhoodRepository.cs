using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NeighborhoodRepository: INeighborhoodRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;
        public NeighborhoodRepository(DB_BabySiterContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;
        }
        public async Task<Neighborhood[]> Get()
        {

            var list = (from b in _DB_BABYSITERContext.Neighborhoods

                        select b).ToArray<Neighborhood>();
            return list;


        }

    }
}
