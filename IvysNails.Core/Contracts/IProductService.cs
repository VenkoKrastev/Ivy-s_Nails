using IvysNails.Core.Models.ViewModels.Home;

namespace IvysNails.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductIndexServiceModel>> LastThreeProduct();
    }
}
