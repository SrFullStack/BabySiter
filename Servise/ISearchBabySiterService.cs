using Entity;

namespace Service
{
    public interface ISearchBabySiterService
    {
        Task<SearchBabysiter> Get(string Password, string Email);
        Task<SearchBabysiter> Insert(SearchBabysiter searchBabysiter);
        void put(int id, SearchBabysiter searchBabysiter);
    }
}