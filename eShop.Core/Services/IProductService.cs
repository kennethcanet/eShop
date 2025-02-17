using eShop.Core.Model.Request;
using eShop.Core.Model.Response;

namespace eShop.Core.Services;

public interface IProductService
{
    Task<bool> AddProductAsync(ProductRequest request);
    Task<bool> DeleteProductByIdAsync(int id);
    Task<List<ProductResponse>> GetAllAsync();
    Task<bool> EditProductAsync(ProductRequest request);
    Task<ProductResponse> GetProductByIdAsync(int id);
}
