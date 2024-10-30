using FoodApp.Menu.DTOs;
using FoodApp.Menu.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Menu.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult<CategoryDTO>> CreateCategory([FromBody] CategoryDTO dto)
    {
        try
        {
            return Ok(await _categoryService.Register(dto));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<CategoryDTO>> GetAll()
    {
        try
        {
            return Ok(await _categoryService.FindAll());
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<CategoryDTO>> Get(int id)
    {
        try
        {
            return Ok(await _categoryService.FindById(id));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<CategoryDTO>> Update([FromBody] CategoryDTO dto)
    {
        try
        {
            if (dto is null)
            {
                return BadRequest("DTO is null on Update Category");
            }

            return Ok(await _categoryService.Update(dto));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
