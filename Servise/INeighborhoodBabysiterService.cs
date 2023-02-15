using Entity;

namespace Service
{
    public interface INeighborhoodBabysiterService
    {
        Task<NeighborhoodBabysiter> Get(int id);
        Task<NeighborhoodBabysiter> Insert(NeighborhoodBabysiter neighborhoodBabysiter);
        void put(int id, NeighborhoodBabysiter neighborhoodBabysiter);


    }
}