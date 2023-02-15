using Entity;
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
        public async Task<Babysiter> Delete(int id,Babysiter babysiter)
        {
            _DB_BABYSITERContext.Babysiters.Remove(babysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return babysiter;
        }
        async public Task<Babysiter> Mail(RequsetSearchBabysiter requsetSearchBabysiter)
        {
           



        }

        //        SELECT REQUSET_SEARCH_BABYSITER.DAY, REQUSET_SEARCH_BABYSITER.PART_OF_DAY, REQUSET_SEARCH_BABYSITER.PRICE, REQUSET_SEARCH_BABYSITER.NEIGHBORHOOD_ID, BabySiter.FIRST_NAME
        //FROM TIME
        //JOIN REQUSET_SEARCH_BABYSITER
        //ON REQUSET_SEARCH_BABYSITER.PRICE= TIME.PRICE and
        //REQUSET_SEARCH_BABYSITER.PART_OF_DAY= TIME.PART_OF_DAY and
        //REQUSET_SEARCH_BABYSITER.DAY= TIME.DAY

        //join NEIGHBORHOOD_BABYSITER
        //on TIME.BABYSITER_ID= NEIGHBORHOOD_BABYSITER.BABYSITER_ID
        //join BabySiter
        //on BabySiter.BABYSITER_ID= TIME.BABYSITER_ID
    }
}
