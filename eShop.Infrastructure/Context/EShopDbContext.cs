using eShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json;

namespace eShop.Infrastructure.Context;

public class EShopDbContext : DbContext
{
    public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var json = File.ReadAllText("products.json");
        var productsFromJson = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        if(productsFromJson is not null)
        {
            modelBuilder.Entity<Product>().HasData(productsFromJson);
        }
    }
}
