using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Repository
{
    public class BabysiterRepository : IBabysiterRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;
        public BabysiterRepository(DB_BabySiterContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;
        }
        public async Task<Babysiter[]> GetAll()
        {

            var list = (from b in _DB_BABYSITERContext.Babysiters

                        select b).ToArray<Babysiter>();
            return list;


        }

        async public Task<Babysiter> Get(string Password, string Email)
        {
            var userQuery = (from Babysiter in _DB_BABYSITERContext.Babysiters
                             where Babysiter.Password == Password && Babysiter.Email == Email
                             select Babysiter).ToArray<Babysiter>();
            return userQuery.FirstOrDefault();
        }

        async public Task<Babysiter> GetByEmail( string Email)
        {
            var userQuery = (from Babysiter in _DB_BABYSITERContext.Babysiters
                             where  Babysiter.Email == Email
                             select Babysiter).ToArray<Babysiter>();
            return userQuery.FirstOrDefault();
        }
        public async Task<Babysiter> Insert(Babysiter babysiter)
        {
            //var userQuery = (from requsetSearchBabysiters in _DB_BABYSITERContext.RequsetSearchBabysiters

            //                  where babysiter.Age == requsetSearchBabysiters.
            //                 select NeighborhoodBabysiter).ToArray<NeighborhoodBabysiter>();
            await _DB_BABYSITERContext.AddAsync(babysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return babysiter;
        }
        public async Task<Babysiter> put(string id, Babysiter babysiter)
        {
            _DB_BABYSITERContext.Babysiters.Update(babysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return babysiter;
        }


        public async Task Delete(int id)
        {
            try
            {
                var babysiter = await _DB_BABYSITERContext.Babysiters.FindAsync(id);
                if (babysiter != null)
                {

                    _DB_BABYSITERContext.Babysiters.Remove(babysiter);
                    await _DB_BABYSITERContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DeleteBook function " + ex.Message);
            }
        }

        //async public Task<Babysiter> Mail(RequsetSearchBabysiter requsetSearchBabysiter)
        //{




        //}


    }
}
