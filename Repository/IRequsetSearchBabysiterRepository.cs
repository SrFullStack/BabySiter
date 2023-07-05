using Entity;

namespace Repository
{
    public interface IRequsetSearchBabysiterRepository
    {
        Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id);
        Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter);
     Task<RequsetSearchBabysiter> put(int id, RequsetSearchBabysiter requsetSearchBabysiter);
        public Task GetEmail(string email);
        Task<RequsetSearchBabysiter[]> GetAllSearchBabysiter();
        public Task RequsetSearch(int price, string day, string part_of_day, int neighborhood_id);

    }
}