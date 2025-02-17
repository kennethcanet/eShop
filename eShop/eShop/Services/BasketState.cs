using eShop.Core.Model.Response;
using System.Linq;

namespace eShop.Services;

public class BasketState : IBasketState
{
    private List<BasketItem> _cachedBasket;

    public BasketState()
    {
        _cachedBasket = new List<BasketItem>();
    }

    public async Task AddAsync(ProductResponse item)
    {

        var cachedItem = _cachedBasket.FirstOrDefault(d=>d.item.Id == item.Id);

        if(cachedItem is null)
        {
            _cachedBasket.Add(new BasketItem(item, 1));
        }
        else
        {
            _cachedBasket.Remove(cachedItem);
            _cachedBasket.Add(new BasketItem(item, cachedItem.Quantity + 1));
        }

        NotifyStateChanged();
    }

    public async Task RemoveAsync(ProductResponse item)
    {

        var cachedItem = _cachedBasket.FirstOrDefault(d => d.item.Id == item.Id);

        if (cachedItem is not null)
        {
            _cachedBasket.Remove(cachedItem);

            NotifyStateChanged();
        }

    }

    public int Count()
    {
        return _cachedBasket.Count();
    }

    public bool IsExists(int id)
    {
        return _cachedBasket.Any(d => d.item.Id == id);
    }

    public Task<IReadOnlyCollection<BasketItem>> GetBasketItemsAsync()
    {
        throw new NotImplementedException();
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}

public record BasketItem(ProductResponse item,int Quantity);
