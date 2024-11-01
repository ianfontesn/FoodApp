using FoodApp.Menu.DTOs;

namespace FoodApp.Menu.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDTO> Register(ProductDTO productDTO);

        Task<ProductDTO> Update(ProductDTO productDTO);

        Task<ProductDTO> Delete(int id);

        Task<ProductDTO> FindById(int productId);

        Task<ProductDTO> FindByName(string productName);

        Task<IList<ProductDTO>> FindAll();
    }
}
