using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RequsetSearchBabysiterService: IRequsetSearchBabysiterService
    {
        private readonly  IRequsetSearchBabysiterRepository _IRequsetSearchBabysiterRepository;
        public RequsetSearchBabysiterService(IRequsetSearchBabysiterRepository IRequsetSearchBabysiterRepository)
        {
            _IRequsetSearchBabysiterRepository = IRequsetSearchBabysiterRepository;
        }
        async public Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id)
        {
            {

                return await _IRequsetSearchBabysiterRepository.GetRequsetSearchBabysiter(id);


            }
        }
        public async Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter)
        {
            RequsetSearchBabysiter requsetSearchBabysiter1 = await _IRequsetSearchBabysiterRepository.Insert(requsetSearchBabysiter);
            if (requsetSearchBabysiter1 != null)
            {
                return requsetSearchBabysiter1;
            }
            return null;
        }
        public void put(int id, RequsetSearchBabysiter requsetSearchBabysiter)
        {
            _IRequsetSearchBabysiterRepository.put(id, requsetSearchBabysiter);


        }
    }
}
