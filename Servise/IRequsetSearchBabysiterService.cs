using Entity;

namespace Service
{
    public interface IRequsetSearchBabysiterService
    {
        Task<RequsetSearchBabysiter[]> GetAllSearchBabysiter();

        Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id);
        Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter);
        void put(int id, RequsetSearchBabysiter requsetSearchBabysiter);
        public Task GetEmail(string email);

    }
}