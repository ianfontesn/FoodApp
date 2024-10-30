using FoodApp.Menu.Models;

namespace FoodApp.Menu.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();

        Task<IEnumerable<Product>> GetProductCategorie();

        Task<Product> GetByName(string name);

        Task<Product> GetById(int id);

        Task<Product> Create(Product product);

        Task<Product> Update(Product product);

        Task<Product> Delete(int id);
    }
}
