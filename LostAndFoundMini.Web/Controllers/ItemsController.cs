using Microsoft.AspNetCore.Mvc;

namespace LostAndFoundMini.Web.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
