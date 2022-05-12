using e_Tickets.Data;
using e_Tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _Service;

        public ActorsController(IActorService Service)
        {
            _Service = Service;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _Service.GetAll();
            return View(data);
        }
    }
}
