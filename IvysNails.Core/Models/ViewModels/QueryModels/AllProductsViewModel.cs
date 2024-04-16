using IvysNails.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace IvysNails.Core.Models.ViewModels.QueryModels
{
    public class AllProductsViewModel
    {

        public int ProductPerPage { get; } = 10;

        [Display(Name = "Количество")]
        public int TotalProductsCount { get; set; }

        [Display(Name = "Търсене")]
        public string SearchTerm { get; set; } = null!;
        [Display(Name = "Сортиране")]
        public ProductSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

    }
}
