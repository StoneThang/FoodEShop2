using FoodEShopSolution.ViewModel.Common;
using FoodEShopSolution.ViewModels.Catalog.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodEShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest getProductPagingRequest);

    }
}
