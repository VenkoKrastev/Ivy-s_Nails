using IvysNails.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IvysNails.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IvyNailsDbContext _dbContext; 

        public ProductController(IvyNailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _dbContext.Products.ToList(); 
            return Json(products); 
        }
    }
}
