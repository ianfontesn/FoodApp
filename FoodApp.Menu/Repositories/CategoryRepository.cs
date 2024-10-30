using FoodApp.Menu.Context;
using FoodApp.Menu.Helpers.Exceptions.CategoryExceptions;
using FoodApp.Menu.Models;
using FoodApp.Menu.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Menu.Repositories;

public class CategoryRepository : ICategoryRepository
{


    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Category> Create(Category category)
    {
        await _context.Categories.AddAsync(category);
        return category;
    }

    public async Task<Category> Delete(int id)
    {
        var category = await _context.Categories
            .FirstOrDefaultAsync(c => c.Id == id)
            ?? throw new CategoryNotFoundException(id);

        _context.Categories.Remove(category);

        return category;
    }

    public async Task<IList<Category>> GetAll()
    {
        var categoryList = await _context.Categories.ToListAsync();
        return categoryList;
    }

    public async Task<Category> GetById(int id)
    {
        var category = await _context.Categories
            .FirstOrDefaultAsync(c => c.Id == id)
            ?? throw new DeleteCategoryException(id);

        _context.Categories.Remove(category);
        return category;
    }

    public async Task<IList<Category>> GetCategorieProducts()
    {
        throw new NotImplementedException();
    }

    public async Task<Category> Update(Category category)
    {
        var existingCategory = await _context.Categories
            .FirstOrDefaultAsync(c => c.Id == category.Id)
            ?? throw new CategoryNotFoundException(category.Id);

        _context.Categories.Entry(existingCategory).CurrentValues.SetValues(category);

        return existingCategory;

    }
}
