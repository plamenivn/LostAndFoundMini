using LostAndFoundMini.Data;
using LostAndFoundMini.Data.Entities;
using LostAndFoundMini.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFoundMini.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.GetAll();
            return View(items);
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
                _itemService.Create(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }
    }
}
