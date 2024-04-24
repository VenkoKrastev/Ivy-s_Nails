using IvysNails.Infrastructure.Data;
using IvysNails.Infrastructure.Data.Common;
using IvysNails.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IvysNails.Controllers
{
    public class ShoppingCartController : Controller
    {
        private static Dictionary<int, int> cartItems = new Dictionary<int, int>();

        private readonly IvyNailsDbContext dbContext;

        public ShoppingCartController(IvyNailsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult AddToCart(int productId, Repository repository)
        {
            Product product = repository.GetProduct(productId);

            
            if (product != null && product.StockQuantity > 0)
            {
                
                if (cartItems.ContainsKey(productId))
                {
                    
                    cartItems[productId]++;
                }
                else
                {                    
                    cartItems.Add(productId, 1);
                }
                                
                product.StockQuantity--;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "Няма достатъчна наличност";
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public IActionResult All()
        {
            
            string userId = GetUserId(); 

            Cart cart = dbContext.Carts
                .Include(c => c.ProductsCarts)
                .ThenInclude(pc => pc.Product)
                .FirstOrDefault(c => c.UserId == userId);

            if (cart == null)
            {
                
                return View("EmptyCart");
            }

            
            return View(cart);
        }
        private string GetUserId()
        {

            string userEmail = User.Identity.Name;

            
            var user = dbContext.Users.FirstOrDefault(u => u.Email == userEmail);

            
            if (user != null)
            {
                
                return user.Id;
            }
            else
            {                
                return null;
            }
        }
    }
}
