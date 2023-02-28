using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RequsetSearchBabysiterRepository: IRequsetSearchBabysiterRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;

        public RequsetSearchBabysiterRepository(DB_BabySiterContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;


        }
        async public Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id)
        {
            var userQuery = (from RequsetSearchBabysiter in _DB_BABYSITERContext.RequsetSearchBabysiters
                             where RequsetSearchBabysiter.SearchBabysiterId== id
                             select RequsetSearchBabysiter).ToArray<RequsetSearchBabysiter>();
            return userQuery.FirstOrDefault();



        }
        public async Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter)
        {
            await _DB_BABYSITERContext.AddAsync(requsetSearchBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return requsetSearchBabysiter;
        }
        public async Task<RequsetSearchBabysiter> put(int id, RequsetSearchBabysiter requsetSearchBabysiter)
        {
            _DB_BABYSITERContext.RequsetSearchBabysiters.Update(requsetSearchBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return requsetSearchBabysiter;
        }
       
 

    }
}
