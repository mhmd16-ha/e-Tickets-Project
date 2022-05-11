using e_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Tickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Actor_Movies>().HasKey(x => new
            {
                x.ActorId,
                x.MovieId
            });
            model.Entity<Actor_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(x => x.ActorId);
            model.Entity<Actor_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(x => x.MovieId);
            base.OnModelCreating(model);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor_Movies> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


    }
}
