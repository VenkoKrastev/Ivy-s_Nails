using IvysNails.Core.Contracts;
using IvysNails.Core.Enums;
using IvysNails.Core.Extensions;
using IvysNails.Core.Models.ViewModels;
using IvysNails.Core.Models.ViewModels.Home;
using IvysNails.Core.Models.ViewModels.Product;
using IvysNails.Core.Models.ViewModels.QueryModels;
using IvysNails.Infrastructure.Data.Common;
using IvysNails.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace IvysNails.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<ProductIndexServiceModel>> LastThreeProduct()
        {
            return await repository.AllReadOnly<Product>()
                .OrderByDescending(p => p.Id)
                .Take(5)
                .Select(p => new ProductIndexServiceModel() 
                { 
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price
                })
                .ToListAsync();
            
        }

        public async Task<ProductQueryServiceModel> AllAsync(string? imageUrl, 
            string price, 
            ProductSorting sorting = ProductSorting.Newest, 
            int currentPage =1, 
            int productPerPage = 10)
        {
            var productToShow = repository.AllReadOnly<Product>();

            if (!string.IsNullOrEmpty(imageUrl))
            {
                productToShow = productToShow.Where(p => p.ImageUrl == imageUrl);
            }

            if (!string.IsNullOrEmpty(price))
            {
                productToShow = productToShow.Where(p=> p.Price.ToString() == price);
            }

            productToShow = sorting switch
            {
                ProductSorting.Oldest => productToShow.OrderBy(p => p.Id),
                ProductSorting.PriceAscending => productToShow.OrderBy(p => p.Price),
                ProductSorting.PriceDescending => productToShow.OrderByDescending(p => p.Price),
                _=>productToShow.OrderByDescending(p => p.Id)
            };

            var products = await productToShow
                .Skip((currentPage - 1) * productPerPage)
                .Take(productPerPage)
                .ProjectToProductServiceModel()
                .ToListAsync();

           

            int totalProducts = await productToShow.CountAsync();

            return new ProductQueryServiceModel()
            {
                //Products = products,
                TotalProductsCount = totalProducts
            };

        }



        public async Task<Product> FindProductByIdAsync(int productId)
        {
            return await repository.AllReadOnly<Product>()
                .FirstOrDefaultAsync(r => r.Id == productId);
        }

        public async Task<bool> ProductExistsAsync(int productId)
        {
            return await repository.AllReadOnly<Product>()
                .AnyAsync(p => p.Id == productId);
        }

        public async Task<ProductViewModel> DetailsAsync(int productId)
        {
            Product? currentProduct = await repository.AllReadOnly<Product>()
                .FirstOrDefaultAsync(p => p.Id == productId);

            var currentProductDetails = new ProductViewModel()
            {
                Id = currentProduct.Id,
                Name = currentProduct.Name,
                Price = currentProduct.Price,
                Details = currentProduct.Details,
                ImageUrl = currentProduct.ImageUrl,
                
            };

            return currentProductDetails;
        }

        public async Task<IEnumerable<ProductCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<ProductCategory>()
                .Select(pc => new ProductCategoryServiceModel() 
                { 
                    Id = pc.Id,
                    Name = pc.Name,
                })
                .ToListAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<Product>()
                .AnyAsync(p => p.Id == id);
        }

        public async Task<int> CreateAsync(ProductFormModel model)
        {
            var product = new Product
            {
                Name = model.Title,
                Price = model.Price,
                Details = model.Details,
                ImageUrl = model.ImageUrl,
                StockQuantity = model.Qty,
                ProductCategoryId = model.CategoryId
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            return product.Id;
        }

        public async Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(int id)
        {
            return await repository.AllReadOnly<Product>()
                .Where(p => p.Id == id)
                .Select(p => new ProductDetailsServiceModel()
                {
                    Id = p.Id,
                    Category = p.ProductsCategories.Name,
                    Description = p.Details,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Title = p.Name
                })
                .FirstAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<ProductCategory>()
                .AnyAsync(c => c.Id == categoryId);
        }
    }
}
