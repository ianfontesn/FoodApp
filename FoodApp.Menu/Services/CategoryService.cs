using AutoMapper;
using FoodApp.Menu.DTOs;
using FoodApp.Menu.Models;
using FoodApp.Menu.Repositories.Interfaces;
using FoodApp.Menu.Repositories.UnitOfWork;
using FoodApp.Menu.Services.Interfaces;

namespace FoodApp.Menu.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            this.mapper = mapper;
        }


        public async Task<CategoryDTO> Delete(int id)
        {
            var entity = await _categoryRepository.Delete(id);
            return mapper.Map<CategoryDTO>(entity);
        }

        public async Task<IList<CategoryDTO>> FindAll()
        {
            var entitylist = await _categoryRepository.GetAll();
            return mapper.Map<IList<CategoryDTO>>(entitylist);
        }

        public async Task<CategoryDTO> FindById(int categoryId)
        {
            var entity = await _categoryRepository.GetById(categoryId);
            return mapper.Map<CategoryDTO>(entity);
        }

        public async Task<CategoryDTO> FindByName(string productName)
        {
            var entity = await _categoryRepository.GetByName(productName);
            return mapper.Map<CategoryDTO>(entity);
        }

        public async Task<CategoryDTO> FindAllProductsWithThisCategory(CategoryDTO categoryDTO)
        {
            var dto = mapper.Map<CategoryDTO>(await _categoryRepository.GetCategoryProducts(mapper.Map<Category>(categoryDTO)));
            return dto ;
        }

        public async Task<CategoryDTO> Register(CategoryDTO categoryDTO)
        {
            var entity = await _categoryRepository.Create(mapper.Map<Category>(categoryDTO));

            return mapper.Map<CategoryDTO>(entity);
        }

        public async Task<CategoryDTO> Update(CategoryDTO categoryDTO)
        {
            var entity = await _categoryRepository.Update(mapper.Map<Category>(categoryDTO));
            return mapper.Map<CategoryDTO>(entity);
        }

        public async Task<CategoryDTO> UpdateProductsOnCategory(CategoryDTO categoryDTO)
        {
            var entity = await _categoryRepository.GetById(categoryDTO.Id);
            entity.Products = categoryDTO.Products;
            return mapper.Map<CategoryDTO> (await _categoryRepository.Update(entity));

        }
    }
}
