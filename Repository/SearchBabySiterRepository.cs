using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SearchBabySiterRepository: ISearchBabySiterRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;

        public SearchBabySiterRepository(DB_BabySiterContext DB_BABYSITERContext) {
            _DB_BABYSITERContext= DB_BABYSITERContext;


        }
        async public Task<SearchBabysiter> Get(string Password, string Email)
        {
            var userQuery = (from SearchBabysiter in _DB_BABYSITERContext.SearchBabysiters
                             where SearchBabysiter.Password == Password && SearchBabysiter.Email == Email
                             select SearchBabysiter).ToArray<SearchBabysiter>();
            return userQuery.FirstOrDefault();



        }
        public async Task<SearchBabysiter> Insert(SearchBabysiter searchBabysiter)
        {
            await _DB_BABYSITERContext.AddAsync(searchBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return searchBabysiter;
        }
        public async Task<SearchBabysiter> put(int id, SearchBabysiter searchBabysiter)
        {
            _DB_BABYSITERContext.SearchBabysiters.Update(searchBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return searchBabysiter;
        }

    }
}
