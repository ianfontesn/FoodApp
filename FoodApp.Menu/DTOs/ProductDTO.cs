using FoodApp.Menu.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FoodApp.Menu.DTOs
{
    public class ProductDTO
    {
        [Required(ErrorMessage = "The reference code is required.")]
        [MinLength(1), MaxLength(10)]
        public string? ReferenceCode { get; set; } = String.Empty;

        [Required(ErrorMessage = "The name is required.")]
        [MinLength(3), MaxLength(200)]
        public string? Name { get; set; } = String.Empty;

        [MinLength(3), MaxLength(200)]
        public string? Description { get; set; } = String.Empty;

        [MaxLength(200)]
        public string? ImageUrl { get; set; } = String.Empty;

        [Required(ErrorMessage = "The price is required")]
        public decimal? Price { get; set; } = 0;

        public IList<Category> Category { get; set; } = [];
    }
}
