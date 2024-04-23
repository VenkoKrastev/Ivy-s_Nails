using System.Linq;
using IvysNails.Core.Contracts;
using IvysNails.Core.Models.ViewModels.QueryModels;
using IvysNails.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace IvysNails.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProductService productService;

        private readonly IvyNailsDbContext db ;

        public ProductController(IProductService productService, IvyNailsDbContext db)
        {
            this.productService = productService;
            this.db = db;
        }

        //[AllowAnonymous]
        //[HttpGet]
        //public async Task<IActionResult> All([FromQuery]AllProductsQueryModel model)
        //{
        //    var allProducts = await productService.AllAsync(model.ImageUrl, model.Price, model.Sorting, model.CurrentPage, model.ProductPerPage);

        //    model.Products =  allProducts.Products.Select(p => p.Product).ToList();
        //    model.TotalProductsCount = allProducts.TotalProductsCount;


        //    return View(model);
        //}

        [HttpGet]
        public IActionResult All()
        {
            var products = db.Products.ToList();
            return View(products);
        }
    }
}
