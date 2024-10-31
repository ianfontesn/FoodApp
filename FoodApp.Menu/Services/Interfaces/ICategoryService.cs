using FoodApp.Menu.DTOs;

namespace FoodApp.Menu.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDTO> Register(CategoryDTO categoryDTO);

        Task<CategoryDTO> Update(CategoryDTO categoryDTO);

        Task<CategoryDTO> Delete(int id);

        Task<CategoryDTO> FindById(int categoryId);

        Task<CategoryDTO> FindByName(string categoryName);

        Task<CategoryDTO> FindByReferenceCode(string referenceCode);

        Task<IList<CategoryDTO>> FindAll();
    }
}
