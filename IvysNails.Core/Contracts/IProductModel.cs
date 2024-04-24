using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvysNails.Core.Contracts
{
    public interface IProductModel
    {
        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}
