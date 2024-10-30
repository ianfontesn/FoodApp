using FoodApp.Menu.Models;

namespace FoodApp.Menu.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IList<Category>> GetAll();

        Task<Category> GetById(int id);

        Task<Category> GetByReferenceCode(string referenceCode);

        Task<Category> GetByName(string name);

        Task<Category> Create(Category category);

        Task<Category> Update(Category category);

        Task<Category> Delete(int id);
    }
}
