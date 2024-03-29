﻿using Entity;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<Babysiter[]> GetAll()
        {

            {
                return await _IBabysiterRepository.GetAll();



            }

        }
        async public Task<Babysiter> Get(string Password, string Email)
        {
            {

                return await _IBabysiterRepository.Get(Password, Email);


            }
        }

        async public Task<Babysiter> GetByEmail( string Email)
        {
            {

                return await _IBabysiterRepository.GetByEmail(Email);


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

