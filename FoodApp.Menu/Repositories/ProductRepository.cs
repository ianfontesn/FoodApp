using FoodApp.Menu.Context;
using FoodApp.Menu.Helpers.Exceptions.ProductExceptions;
using FoodApp.Menu.Models;
using FoodApp.Menu.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Menu.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Create(Product product)
        {
            await _context.Products.AddAsync(product);
            return product;
        }

        public async Task<Product> Delete(int id)
        {
            var Product = await _context.Products
                .FirstOrDefaultAsync(c => c.Id == id)
                ?? throw new ProductNotFoundException(id: id);

            _context.Products.Remove(Product);

            return Product;
        }

        public async Task<IList<Product>> GetAll()
        {
            var ProductList = await _context.Products.ToListAsync();
            return ProductList;
        }

        public async Task<Product> GetById(int id)
        {
            var Product = await _context.Products
                .FirstOrDefaultAsync(c => c.Id == id)
                ?? throw new DeleteProductException(id);

            _context.Products.Remove(Product);
            return Product;
        }

        public async Task<Product> GetByName(string name)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Name == name)
                ?? throw new ProductNotFoundException(name: name);

            _context.Products.Remove(product);
            return product;
        }

        public Task<IEnumerable<Product>> GetProductCategorie()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Update(Product Product)
        {
            var existingProduct = await _context.Products
                .FirstOrDefaultAsync(c => c.Id == Product.Id)
                ?? throw new ProductNotFoundException(Product.Id);

            _context.Products.Entry(existingProduct).CurrentValues.SetValues(Product);

            return existingProduct;

        }

        Task<IEnumerable<Product>> IProductRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
