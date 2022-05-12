using e_Tickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_Tickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor Get(int id);
        void Add(Actor actor);
        Actor Update(int id,Actor actor);
        void Delete(int id);
    }
}
