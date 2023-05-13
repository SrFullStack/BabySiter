using Entity;

namespace Service
{
    public interface INeighborhoodService
    {
        Task<Neighborhood[]> Get();
    }
}