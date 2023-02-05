using Entity;

namespace Repository
{
    public interface ISearchBabySiterRepository
    {
        Task<SearchBabysiter> Get(string Password, string Email);
        Task<SearchBabysiter> Insert(SearchBabysiter searchBabysiter);
        Task<SearchBabysiter> put(int id, SearchBabysiter searchBabysiter);
    }
}