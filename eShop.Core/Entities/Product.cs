using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Core.Entities;

public class Product
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }=string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime CreateDateUtc { get; set; } = new DateTime(2025,2,16);
    public int CreatedBy { get; set; } = 0;
    public DateTime? UpdatedDateUtc { get; set; }
    public int UpdatedBy { get; set; } = 0;
}
