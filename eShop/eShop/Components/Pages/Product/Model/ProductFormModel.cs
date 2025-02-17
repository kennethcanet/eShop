using System.ComponentModel.DataAnnotations;

namespace eShop.Components.Pages.Product.Model;

public class ProductFormModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "ImageUrl required.")]
    public string? ImageUrl { get; set; }

    [Required(ErrorMessage = "Title required.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Description required.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Price required.")]
    public decimal? Price { get; set; }
}
