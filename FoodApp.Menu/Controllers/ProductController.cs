using FoodApp.Menu.DTOs;
using FoodApp.Menu.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Menu.Controllers;


[Route("api/v1/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult<ProductDTO>> CreateCategory([FromBody] ProductDTO dto)
    {
        try
        {
            return Ok(await _productService.Register(dto));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<ProductDTO>> GetAll()
    {
        try
        {
            return Ok(await _productService.FindAll());
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<ProductDTO>> GetById(int id)
    {
        try
        {
            return Ok(await _productService.FindById(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    [Route("{referenceCode}")]
    public async Task<ActionResult<ProductDTO>> FindByRefereceCode(string referenceCode)
    {
        try
        {
            return Ok(await _productService.FindByReferenceCode(referenceCode));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ProductDTO>> Update([FromBody] ProductDTO dto)
    {
        try
        {
            if (dto is null)
            {
                return BadRequest("DTO is null on Update Product");
            }

            return Ok(await _productService.Update(dto));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}