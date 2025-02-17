using eShop.Core.Entities;
using eShop.Core.Repositories;
using eShop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly EShopDbContext _context;

    public ProductRepository(IDbContextFactory<EShopDbContext> factory)
    {
        _context = factory.CreateDbContext();
    }

    public async Task AddAsync(Product entity)
    {
        var product = _context.Products.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        var product = await GetByIdAsync(id);
        if (product is not null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task EditAsync(Product entity)
    {
        _context.Products.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var results = await _context.Products.AsNoTracking().ToListAsync();
        return results;
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        var product = await _context.Products.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        return product;
    }
}
