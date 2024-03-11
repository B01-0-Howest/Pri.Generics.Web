using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pri.CleanArchitecture.Core.Interfaces.Services;

namespace Pri.WebApi.Food.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetAllAsync());
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok($"Products with id:{id}");
        }

    }
}
