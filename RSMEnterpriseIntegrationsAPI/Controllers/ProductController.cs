using Microsoft.AspNetCore.Mvc;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;

namespace RSMEnterpriseIntegrationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAll")]

        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetAll());

        }
    }
}
