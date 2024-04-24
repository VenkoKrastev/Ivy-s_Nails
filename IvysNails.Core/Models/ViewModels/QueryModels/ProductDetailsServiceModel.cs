using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvysNails.Core.Models.ViewModels.QueryModels
{
    public class ProductDetailsServiceModel : ProductServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;


    }
}
