using e_Tickets.Data.Base;
using e_Tickets.Models;

namespace e_Tickets.Data.Services
{
    public class ProducerService :EntityBaseRepository<Producer>,IProducerService
    {
        public ProducerService(AppDbContext context) : base(context)
        {
        }
    }
}
