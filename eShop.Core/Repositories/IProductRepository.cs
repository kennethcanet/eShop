using eShop.Core.Entities;

namespace eShop.Core.Repositories;

public interface IProductRepository
{
    Task AddAsync(Product entity);
    Task<IEnumerable<Product>> GetAllAsync();
    Task DeleteByIdAsync(int id);
    Task EditAsync(Product entity);
    Task<Product?> GetByIdAsync(int id);
}
