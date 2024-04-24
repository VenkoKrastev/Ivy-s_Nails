using IvysNails.Core.Contracts;
using IvysNails.Core.Extensions;
using IvysNails.Core.Models.ViewModels.QueryModels;
using IvysNails.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;


namespace IvysNails.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProductService productService;

        private readonly IvyNailsDbContext db;


        public ProductController(IProductService _productService, IvyNailsDbContext _db)
        {
            productService = _productService;
            db = _db;

        }


        [HttpGet]
        public IActionResult All()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormModel()
            {
                Categories = await productService.AllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (await productService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = await productService.AllCategoriesAsync();

                return View(model);
            }

            int newProductId = await productService.CreateAsync(model);

            return RedirectToAction("All", "Product");
        }


        public async Task<IActionResult> Details(int id, string information)
        {
            if (await productService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await productService.ProductDetailsByIdAsync(id);

            if (information != model.GetInformation())
            {
                return BadRequest();
            }

            return View(model);

        }
    }
}   
