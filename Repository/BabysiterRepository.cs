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
            await _DB_BABYSITERContext.AddRangeAsync(babysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return babysiter;
        }
    }
}
