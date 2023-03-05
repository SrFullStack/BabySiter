using Entity;

namespace Repository
{
    public interface INeighborhoodBabysiterRepository
    {
        Task<NeighborhoodBabysiter[]> Get(int id);
        Task<NeighborhoodBabysiter> Insert(NeighborhoodBabysiter neighborhoodBabysiter);
        Task<NeighborhoodBabysiter> put(int id, NeighborhoodBabysiter neighborhoodBabysiter);

    }
}