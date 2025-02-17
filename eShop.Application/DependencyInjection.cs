using eShop.Application.Services;
using eShop.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Application;

public static class DependencyInjection
{
	public static IServiceCollection AddApplication(this IServiceCollection services)
	{
		services.AddTransient<IProductService, ProductService>();
		return services;
	}
}
