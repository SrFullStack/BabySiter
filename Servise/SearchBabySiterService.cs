using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public class SearchBabySiterService: ISearchBabySiterService
    {
        private readonly  ISearchBabySiterRepository _searchBabySiterRepository;  
        public SearchBabySiterService(ISearchBabySiterRepository searchBabySiterRepository ) {
            _searchBabySiterRepository= searchBabySiterRepository;
        }
        async public Task<SearchBabysiter> Get(string Password, string Email)
        {
            {

                return await _searchBabySiterRepository.Get(Password, Email);


            }
        }
        public async Task<SearchBabysiter> Insert(SearchBabysiter searchBabysiter)
        {
            SearchBabysiter ressearch = await _searchBabySiterRepository.Insert(searchBabysiter);
            if (ressearch != null)
            {
                return ressearch;
            }
            return null;
        }
        public void put(int id, SearchBabysiter searchBabysiter)
        {
            _searchBabySiterRepository.put(id, searchBabysiter);


        }

    }
}
