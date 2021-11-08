using Microsoft.AspNetCore.Mvc;
using ProductDataHub.DTOs;
using ProductDataHub.Services;

namespace ProductDataHub.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private IProductService _productService = null;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public IActionResult getProductById(int id)
        {
            ProductDto productDto = _productService.GetProductById(id);
            if (productDto != null)
                return Ok();
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult InsertProduct(ProductDto productDto)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductDto productDto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(ProductDto productDto)
        {
            return Ok();
        }
    }
}
