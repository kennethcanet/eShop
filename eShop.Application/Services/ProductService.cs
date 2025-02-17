using eShop.Core.Entities;
using eShop.Core.Model.Request;
using eShop.Core.Model.Response;
using eShop.Core.Repositories;
using eShop.Core.Services;
using Microsoft.Extensions.Logging;

namespace eShop.Application.Services;

public class ProductService : IProductService
{
	private readonly IProductRepository _productRepository;
	private readonly ILogger<ProductService> _logger;
    public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
    {
        _productRepository = productRepository;
        _logger = logger;
    }

    public async Task<bool> AddProductAsync(ProductRequest request)
	{
		_logger.LogInformation("AddProductAsync | {request}", request);

        try
		{
			await _productRepository.AddAsync(
				new Product
				{
					Description = request.Description,
					ImageUrl = request.ImageUrl,
					Price = request.Price,
					Title = request.Title,
					CreateDateUtc = DateTime.UtcNow,
					CreatedBy = 0
				});
            _logger.LogInformation("AddProductAsync | {request} | Success", request);
            return true;
		}
		catch (Exception ex)
		{
            _logger.LogError("AddProductAsync | {request} | Error={ex}", request,ex);
            throw;
		}
	}

	public async Task<List<ProductResponse>> GetAllAsync()
	{
        _logger.LogInformation("GetAllAsync");
        try
		{
			var entityResult = await _productRepository.GetAllAsync();

			return entityResult
				.Select(d =>
					new ProductResponse
					{
						Description = d.Description,
						Id = d.Id,
						ImageUrl = d.ImageUrl,
						Price = d.Price,
						Title = d.Title
					}).ToList();

		}
		catch (Exception ex)
		{
            _logger.LogError("GetAllAsync | Error={ex}", ex);
            throw;
		}
	}

    public async Task<bool> DeleteProductByIdAsync(int id)
    {
        _logger.LogInformation("DeleteByIdAsync | Id={id}",id);
        try
        {
             await _productRepository.DeleteByIdAsync(id);

            return true;

        }
        catch (Exception ex)
        {
            _logger.LogError("DeleteByIdAsync | Error={ex}", ex);
            throw;
        }
    }

    public async Task<bool> EditProductAsync(ProductRequest request)
    {
        _logger.LogInformation("EditProductAsync | {request}", request);

        try
        {
            await _productRepository.EditAsync(
                new Product
                {
                    Id = request.Id,
                    Description = request.Description,
                    ImageUrl = request.ImageUrl,
                    Price = request.Price,
                    Title = request.Title,
                    CreateDateUtc = DateTime.UtcNow,
                    CreatedBy = 0
                });
            _logger.LogInformation("EditProductAsync | {request} | Success", request);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError("EditProductAsync | {request} | Error={ex}", request, ex);
            throw;
        }
    }

    public async Task<ProductResponse> GetProductByIdAsync(int id)
    {
        _logger.LogInformation("GetProductByIdAsync | {id}",id);
        try
        {
            var entityResult = await _productRepository.GetByIdAsync(id);

            if(entityResult is not null)
            {

                return new ProductResponse
                {
                    Description = entityResult.Description,
                    Id = entityResult.Id,
                    ImageUrl = entityResult.ImageUrl,
                    Price = entityResult.Price,
                    Title = entityResult.Title
                };
            }

            return new();

        }
        catch (Exception ex)
        {
            _logger.LogError("GetProductByIdAsync | Error={ex}", ex);
            throw;
        }
    }
}
