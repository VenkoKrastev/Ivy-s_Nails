using Microsoft.AspNetCore.Mvc;

namespace IvysNails.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
