using IvysNails.Core.Models.ViewModels.QueryModels;
using IvysNails.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvysNails.Core.Models.ViewModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Details { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string ProductsCategories { get; set; } = null!;


    }
}
