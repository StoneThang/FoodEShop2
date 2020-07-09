using FoodEShopSolution.ViewModel.Common;
using System.Collections.Generic;

namespace FoodEShopSolution.ViewModels.Catalog.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }

    }
}
