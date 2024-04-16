using IvysNails.Core.Contracts;
using IvysNails.Core.Models.ViewModels.Home;
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
                .Take(3)
                .Select(p => new ProductIndexServiceModel() 
                { 
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price
                })
                .ToListAsync();
                

            
        }
    }
}
