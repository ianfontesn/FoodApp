using FoodApp.Menu.Models;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.Menu.DTOs
{
    public class CategoryDTO
    {
        [Required(ErrorMessage = "The name is required.")]
        [MinLength(3), MaxLength(200)]
        public string? Name { get; set; } = String.Empty;

        [MinLength(3), MaxLength(200)]
        public string? Description { get; set; } = String.Empty;

        [MaxLength(200)]
        public string? ImageUrl { get; set; } = String.Empty;

        public IList<Product>? Products { get; set; }
    }
}
