using e_Tickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context; 
        }
        public void Add(Actor actor)
        {
           _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public Actor Get(int id)
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Id == id);
            return actor;
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var Result =await _context.Actors.ToListAsync();
            return Result;
        }

        public Actor Update(int id, Actor actor)
        {
            var actor1=Get(id);
            actor1.Id = actor.Id;
            actor1.FullName= actor.FullName;
            actor1.ProfilePictureUrl = actor.ProfilePictureUrl;
            actor1.Bio= actor.Bio; 
          
            return actor1;
        }
    }
}
