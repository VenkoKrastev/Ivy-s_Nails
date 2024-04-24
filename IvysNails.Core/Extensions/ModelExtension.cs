using IvysNails.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IvysNails.Core.Extensions
{
    public static class ModelExtension
    {
        public static string GetInformation(this IProductModel product)
        {
            string info = product.Title.Replace(" ", "-") + GetAddress(product.Title);
            info = Regex.Replace(info, @"[^a-zA-Z0-9\-]", string.Empty);

            return info;
        }

        private static string GetAddress(string title)
        {
            title = string.Join("-", title.Split(" ").Take(3));

            return title;
        }
    }
}
