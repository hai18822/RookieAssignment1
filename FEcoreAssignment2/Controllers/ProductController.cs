using FEcoreAssignment2.DTOs.Product;
using FEcoreAssignment2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FEcoreAssignment2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public AddProductResponse? Add([FromBody] AddProduct addModel)
        {
            return _productService.Add(addModel);
        }
    }
}