using FoodApp.Menu.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FoodApp.Menu.DTOs
{
    public class CategoryDTO
    {
        [Required(ErrorMessage = "The id is required.")]
        public int Id { get; set; } = 0;

        [Required(ErrorMessage = "The name is required.")]
        [MinLength(3), MaxLength(200)]
        public string? Name { get; set; } = String.Empty;

        [MinLength(3), MaxLength(200)]
        public string? Description { get; set; } = String.Empty;

        [MaxLength(200)]
        public string? ImageUrl { get; set; } = String.Empty;

        [JsonIgnore]
        public IList<Product>? Products { get; set; }
    }
}
