using Entity;

namespace Service
{
    public interface IRequsetSearchBabysiterService
    {
        Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id);
        Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter);
        void put(int id, RequsetSearchBabysiter requsetSearchBabysiter);
    }
}