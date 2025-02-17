using eShop.Core.Repositories;
using eShop.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IProductRepository, ProductRepository>();

        return services;
    }
}
