using LostAndFoundMini.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFoundMini.Web.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(item);
        }
    }
}
