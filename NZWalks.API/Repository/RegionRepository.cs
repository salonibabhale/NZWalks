using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NSWalksDbContext nSWalksDbContext;

        public RegionRepository(NSWalksDbContext nSWalksDbContext)
        {
            this.nSWalksDbContext = nSWalksDbContext;
        }

        public IEnumerable<Region> Getall()
        {
            return nZWalksDbContext.Regions.ToList();
        }
    }
}
