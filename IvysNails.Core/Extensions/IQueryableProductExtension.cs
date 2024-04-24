using IvysNails.Core.Models.ViewModels.QueryModels;
using IvysNails.Infrastructure.Data.Models;

namespace IvysNails.Core.Extensions
{
    public static class IQueryableProductExtension
    {
        public static IQueryable<ProductServiceModel> ProjectToProductServiceModel(this IQueryable<Product> products)
        {
            return products.Select(b => new ProductServiceModel()
            {
                Id = b.Id,
                Title = b.Name,             
                Price = b.Price,
                ImageUrl = b.ImageUrl
            });
        }
    }
}
