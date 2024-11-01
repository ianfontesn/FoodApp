using FoodApp.Menu.Context;
using FoodApp.Menu.Helpers.Exceptions.ProductExceptions;
using FoodApp.Menu.Models;
using FoodApp.Menu.Repositories.Interfaces;
using FoodApp.Menu.Repositories.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Menu.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        private readonly IUnityOfWork _unityOfWork;

        public ProductRepository(AppDbContext context, IUnityOfWork unityOfWork)
        {
            _context = context;
            _unityOfWork = unityOfWork;
        }

        public async Task<Product> Create(Product product)
        {
            await _context.Products.AddAsync(product);
            _unityOfWork.Commit();

            return product;
        }

        public async Task<Product> Delete(int id)
        {
            var Product = await _context.Products
                .FirstOrDefaultAsync(c => c.Id == id)
                ?? throw new ProductNotFoundException(id: id);

            _context.Products.Remove(Product);
            _unityOfWork.Commit();

            return Product;
        }

        public async Task<Product> Update(Product product)
        {
            var existingProduct = await _context.Products
                .FirstOrDefaultAsync(c => c.ReferenceCode == product.ReferenceCode)
                ?? throw new ProductNotFoundException(name: product.ReferenceCode!);

            product.Id = existingProduct.Id;
            _context.Entry(existingProduct).CurrentValues.SetValues(product);
            _unityOfWork.Commit();

            return existingProduct;

        }

        public async Task<IList<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products
                .FirstOrDefaultAsync(c => c.Id == id)
                ?? throw new ProductNotFoundException(id);
        }

        public async Task<Product> GetByReferenceCode(string referenceCode)
        {
            return await _context.Products
                .FirstOrDefaultAsync(c => c.ReferenceCode == referenceCode)
                ?? throw new ProductNotFoundException(name: referenceCode);
        }

        public async Task<Product> GetByName(string name)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.Name == name)
                ?? throw new ProductNotFoundException(name: name);
        }

    }
}
