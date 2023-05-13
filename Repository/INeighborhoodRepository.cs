using Entity;

namespace Repository
{
    public interface INeighborhoodRepository
    {
        Task<Neighborhood[]> Get();

    }
}