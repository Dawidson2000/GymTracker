using Microsoft.EntityFrameworkCore;

namespace GymTracker.Entities
{
    public class GymTrackerContext : DbContext
    {
        public GymTrackerContext(DbContextOptions<GymTrackerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
