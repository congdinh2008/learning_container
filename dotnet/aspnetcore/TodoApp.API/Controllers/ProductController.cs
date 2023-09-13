using Microsoft.AspNetCore.Mvc;
using TodoApp.API.Data;

namespace TodoApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ViVuDbContext _dbContext;
    public ProductController(ViVuDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetAllProducts")]
    public IActionResult Get()
    {
       var products = _dbContext.Products.ToList();
       return Ok(products);
    }
}
