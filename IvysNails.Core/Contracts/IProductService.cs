using IvysNails.Core.Enums;
using IvysNails.Core.Models.ViewModels;
using IvysNails.Core.Models.ViewModels.Home;
using IvysNails.Core.Models.ViewModels.QueryModels;

namespace IvysNails.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductIndexServiceModel>> LastThreeProduct();

        Task<ProductQueryServiceModel> AllAsync(
            string? imageUrl = null,
            string? price = null,
            ProductSorting sorting = ProductSorting.Newest,
            int currentPage = 1,
            int productPerPage = 10
            );

        Task<IEnumerable<ProductCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> ExistsAsync(int id);

        Task<int> CreateAsync(ProductFormModel model);

        Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(int id);

        Task<bool> CategoryExistsAsync(int categoryId);




    }
}
