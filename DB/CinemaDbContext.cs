using CinemaWebApi.DB.EntityConfiguration;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.DB
{
    public class CinemaDbContext : DbContext, ICinemaDbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Role> Roles { get; set; }

        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options)
        {

            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CinemaConfiguration());
            builder.ApplyConfiguration(new WorkerConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            base.OnModelCreating(builder);
        }
        }
}
