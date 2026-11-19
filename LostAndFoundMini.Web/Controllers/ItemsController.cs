using LostAndFoundMini.Data;
using LostAndFoundMini.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFoundMini.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ItemDbContext _context;

        public ItemsController(ItemDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Items.ToList();
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
