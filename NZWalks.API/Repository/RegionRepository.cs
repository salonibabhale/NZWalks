using Microsoft.EntityFrameworkCore.ChangeTracking;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NSWalksDbContext nSWalksDbContext;
        private object nZWalksdbContext;

        public RegionRepository(NSWalksDbContext nSWalksDbContext)
        {
            this.nSWalksDbContext = nSWalksDbContext;
        }

        public async Task<Region> AddAsync(Region region)
        {
            region.Id = Guid.NewGuid();
            await nZWalksDbContext.AddAsync(region);
            await nZWalksDbContext.Save.Changes.AddAsync(region);
            return region;
        }

        public async Task<IEnumerable<Region>> Getallasync()
        {
            return await nZWalksDbContext.Regions.ToListAsync();
        }

        public Task<IEnumerable<Region>> GetallAsync()
        {
            
        }

        public async Task<Region> GetAsync(Guid id)
        {
           return await nZWalksdbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            
        }
    }
}
 