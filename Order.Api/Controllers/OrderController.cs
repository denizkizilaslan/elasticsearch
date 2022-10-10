using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrders")]
        public List<string> GetOrders()
        {
            List<string> products = new List<string>();
            products.Add("Order 1");
            products.Add("Order 2");

            _logger.LogInformation("OrderService executed");
            return products;

        }
    }
}
