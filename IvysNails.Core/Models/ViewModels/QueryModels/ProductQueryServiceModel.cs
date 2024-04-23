using IvysNails.Core.Services;

namespace IvysNails.Core.Models.ViewModels.QueryModels
{
    public class ProductQueryServiceModel
    {
        public int TotalProductsCount { get; set; }
        public IEnumerable<ProductService> Products { get; set; } = new HashSet<ProductService>();
    }
}
