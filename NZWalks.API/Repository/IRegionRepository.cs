using NZWalks.API.Controllers;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repository
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetallAsync();
        Task<Region>GetAsync(Guid id);
        Task <Region>AddAsync(Region region);
    }
}