using Entity;

namespace Repository
{
    public interface IRequsetSearchBabysiterRepository
    {
        Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id);
        Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter);
     Task<RequsetSearchBabysiter> put(int id, RequsetSearchBabysiter requsetSearchBabysiter);
    }
}