using e_Tickets.Data;
using e_Tickets.Data.Services;
using e_Tickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_Tickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _Service;

        public CinemasController(ICinemaService Service)
        {
            _Service = Service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _Service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cinema model)
        {
            if (ModelState.IsValid)
            {
                await _Service.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _Service.Get(id);
            if (result == null) return View("NotFound");
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema model)
        {
            if (ModelState.IsValid)
            {

                await _Service.Update(id, model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _Service.Get(id);
            if (result == null) return View("NotFound");
            return View(result);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _Service.Get(id);
            if (result == null) return View("NotFound");
            await _Service.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            var data = await _Service.Get(id);
            if (data == null) return View("NotFound");
            return View(data);
        }
    }
}
