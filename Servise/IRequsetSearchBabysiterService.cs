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
        public Task RequsetSearch(int price, string day, string part_of_day, int neighborhood_id);

    }
}