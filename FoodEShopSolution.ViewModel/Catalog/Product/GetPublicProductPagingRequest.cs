using FoodEShopSolution.ViewModel.Common;

namespace FoodEShopSolution.ViewModels.Catalog.Product
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }

    }
}
