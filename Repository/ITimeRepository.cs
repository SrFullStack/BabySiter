using Entity;

namespace Repository
{
    public interface ITimeRepository
    {
        Task<Time> Get(int BabysiterId);
        Task<Time> Insert(Time time);
        Task<Babysiter> put(int id, Time time);
    }
}