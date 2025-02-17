using eShop.Core.Model.Response;

namespace eShop.Services;

public interface IBasketState
{
    public Task<IReadOnlyCollection<BasketItem>> GetBasketItemsAsync();

    public Task AddAsync(ProductResponse item);
}
