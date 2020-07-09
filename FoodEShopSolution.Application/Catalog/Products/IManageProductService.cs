using FoodEShopSolution.ViewModel.Common;
using FoodEShopSolution.ViewModels.Catalog.Product;
using FoodEShopSolution.ViewModels.Catalog.ProductImages;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodEShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int ProductId);

        
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task AddViewCount(int productId);
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest getProductPagingRequest);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<ProductViewModel> GetById(int productId, string LanguageId);
    }
}
