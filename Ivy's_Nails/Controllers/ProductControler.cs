using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IvysNails.Controllers
{
    [Authorize]
    public class ProductControler : Controller
    {
        [AllowAnonymous]
        public IActionResult All()
        {

            return View();
        }
    }
}
