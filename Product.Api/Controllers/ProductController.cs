using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public List<string> GetProducts()
        {
            List<string> products = new List<string>();
            products.Add("Product 1");
            products.Add("Product 2");
            products.Add("Product 3");

            _logger.LogInformation("ProuctService executed");
            return products;

        }
    }
}
