using Entity;
using Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BabysiterService : IBabysiterService
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
        public async Task<Babysiter> Insert(Babysiter babysiter)
        {
            Babysiter resbabysiter = await _IBabysiterRepository.Insert(babysiter);
            if (resbabysiter != null)
            {
                return resbabysiter;
            }
            return null;
        }
        public  void put(string id,Babysiter babysiter)
        {
            _IBabysiterRepository.put(id,babysiter);


        }
        public void Delete(int id)
        {
            _IBabysiterRepository.Delete(id);


        }
        //public async Task<Babysiter> Mail(RequsetSearchBabysiter requsetSearchBabysiter)
        //{
        //    Babysiter resbabysiter = await _IBabysiterRepository.Mail(requsetSearchBabysiter);
        //    if (resbabysiter != null)
        //    {
        //        return resbabysiter;
        //    }
        //    return null;
        //}


    }

}

