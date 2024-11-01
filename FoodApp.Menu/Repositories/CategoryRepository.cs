using FoodApp.Menu.Context;
using FoodApp.Menu.Models;
using FoodApp.Menu.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using FoodApp.Menu.Helpers.Exceptions.CategoryExceptions;
using FoodApp.Menu.Repositories.UnitOfWork;

namespace FoodApp.Menu.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;
    private readonly IUnityOfWork _unityOfWork;


    public CategoryRepository(AppDbContext context, IUnityOfWork unityOfWork)
    {
        _context = context;
        _unityOfWork = unityOfWork;
    }


    public async Task<Category> Create(Category category)
    {
        await _context.Categories.AddAsync(category);
        _unityOfWork.Commit();

        return category;
    }

    public async Task<Category> Delete(int id)
    {
        var category = await _context.Categories
            .FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new CategoryNotFoundException(id);

        _context.Categories.Remove(category);
        _unityOfWork.Commit();

        return category;
    }

    public async Task<Category> Update(Category category)
    {
        var existingCategory = await _context.Categories
            .FirstOrDefaultAsync(c => c.Id == category.Id)
            ?? throw new CategoryNotFoundException(name: category.ReferenceCode!);

        category.Id = existingCategory.Id;
        _context.Entry(existingCategory).CurrentValues.SetValues(category);
        _unityOfWork.Commit();

        return existingCategory;

    }

    public async Task<IList<Category>> GetAll()
    {
        var categoryList = await _context.Categories.ToListAsync();
        return categoryList;
    }

    public async Task<Category> GetById(int id)
    {
        return await _context.Categories
            .FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new CategoryNotFoundException(id: id);
    }

    public async Task<Category> GetByName(string name)
    {
        return await _context.Categories
            .FirstOrDefaultAsync(p => p.Name == name)
            ?? throw new CategoryNotFoundException(name: name);
    }

    public async Task<IList<Category>> GetCategoryProducts(Category category)
    {
        return await _context.Categories
            .Include(p => p.Products)
            .ToListAsync();
    }
}
