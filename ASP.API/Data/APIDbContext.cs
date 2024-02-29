using ASP.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASP.API.Data
{
    public class APIDbContext: DbContext
    {
        public APIDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {
                
        }


        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }


    }
}
