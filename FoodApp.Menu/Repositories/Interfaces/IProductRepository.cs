using FoodApp.Menu.Models;

namespace FoodApp.Menu.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetAll();

        Task<Product> GetByName(string name);

        Task<Product> GetById(int id);

        Task<Product> GetByReferenceCode(string referenceCode);

        Task<Product> Create(Product product);

        Task<Product> Update(Product product);

        Task<Product> Delete(int id);

    }
}
