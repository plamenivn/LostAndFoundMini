using LostAndFoundMini.Data;
using LostAndFoundMini.Data.Entities;
using LostAndFoundMini.Services.Contracts;
using LostAndFoundMini.Web.ViewModels.Items;
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

        public async Task<IActionResult> Index()
        {
            var items = await _itemService.GetAllAsync();

            var viewModel = new ItemsIndexViewModel
            {
                Items = items
            };

            return View(viewModel);
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
