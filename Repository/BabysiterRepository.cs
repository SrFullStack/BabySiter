using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BabysiterRepository:IBabysiterRepository
    {
        private readonly DB_BABYSITERContext _DB_BABYSITERContext;
        public BabysiterRepository(DB_BABYSITERContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;


        }
        async public Task<Babysiter> Get(string Password, string Email)
        {
            var userQuery = (from Babysiter in _DB_BABYSITERContext.Babysiters
                             where Babysiter.Password == Password && Babysiter.Email == Email
                             select Babysiter).ToArray<Babysiter>();
            return userQuery.FirstOrDefault();



        }
        public async Task<Babysiter> Insert(Babysiter babysiter)
        {
            await _DB_BABYSITERContext.AddAsync(babysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return babysiter;
        }
        public async Task<Babysiter> put(string id,Babysiter babysiter)
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
