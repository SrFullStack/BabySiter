using Entity;
using Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BabysiterService: IBabysiterService
    {
        private readonly IBabysiterRepository _IBabysiterRepository;
        public BabysiterService(IBabysiterRepository IBabysiterRepository)
        {
            _IBabysiterRepository = IBabysiterRepository;
        }

       async public Task<Babysiter> Get(string Password, string Email)
        {
            {
          
                return await _IBabysiterRepository.Get(Password, Email);


            }
        }
    }
}
