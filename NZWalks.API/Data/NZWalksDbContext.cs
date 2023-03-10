using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class nZWalksDbContext:DbContext
    {
        public nZWalksDbContext(DbContextOptions<nZWalksDbContext> options) : base(options)
        { 
        
        }

        public static object Regions { get; internal set; }
        public static object Save { get; internal set; }
        public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }
    public DbSet<Walkdifficulty> Walkdifficulty { get; set; }
     }
}

