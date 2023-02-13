using Entity;

namespace Service
{
    public interface ITimeService
    {
        Task<Time> Get(int BabysiterId);
        Task<Time> Insert(Time time);
        void put(int id,Time time);

    }
}