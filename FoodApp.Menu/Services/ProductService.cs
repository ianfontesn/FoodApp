using AutoMapper;
using FoodApp.Menu.DTOs;
using FoodApp.Menu.Models;
using FoodApp.Menu.Repositories.Interfaces;
using FoodApp.Menu.Services.Interfaces;

namespace FoodApp.Menu.Services;

public class ProductService : IProductService
{
    
    private readonly IProductRepository _productRepository;
    private readonly IMapper mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<ProductDTO> Delete(int id)
    {
        var entity = await _productRepository.Delete(id);
        return mapper.Map<ProductDTO>(entity);
    }

    public async Task<IList<ProductDTO>> FindAll()
    {
        var entitylist = await _productRepository.GetAll();
        return mapper.Map<IList<ProductDTO>>(entitylist);
    }

    public async Task<ProductDTO> FindById(int productId)
    {
        var entity = await _productRepository.GetById(productId);
        return mapper.Map<ProductDTO>(entity);
    }

    public async Task<ProductDTO> FindByName(string productName)
    {
        var entity = await _productRepository.GetByName(productName);
        return mapper.Map<ProductDTO>(entity);
    }

    public async Task<ProductDTO> Register(ProductDTO productDTO)
    {
        var entity = await _productRepository.Create(mapper.Map<Product>(productDTO));
        return mapper.Map<ProductDTO>(entity);
    }

    public async Task<ProductDTO> Update(ProductDTO productDTO)
    {
        var entity = await _productRepository.Update(mapper.Map<Product>(productDTO));
        return mapper.Map<ProductDTO>(entity);
    }

    public async Task<ProductDTO> FindByReferenceCode(string referenceCode)
    {
        var entity = await _productRepository.GetByReferenceCode(referenceCode);
        return mapper.Map<ProductDTO>(entity);
    }
}
