using e_Tickets.Data;
using e_Tickets.Data.Base;
using e_Tickets.Data.Services;
using e_Tickets.Models;

namespace eTickets.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(AppDbContext context) : base(context) { }
    }
}
