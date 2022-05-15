using e_Tickets.Data.Base;
using e_Tickets.Models;

namespace e_Tickets.Data.Services
{
    public class CinemaService: EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(AppDbContext context) : base(context) { }

    }
}
