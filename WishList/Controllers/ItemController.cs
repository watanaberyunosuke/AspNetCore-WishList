using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
