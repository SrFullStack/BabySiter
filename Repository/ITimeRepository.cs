using Entity;

namespace Repository
{
    public interface ITimeRepository
    {
        Task<Time[]> Get(int BabysiterId);
        Task<Time> Insert(Time time);
        Task<Time> put(int id, Time time);
    }
}