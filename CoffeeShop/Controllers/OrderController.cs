using CoffeeShop.BusinessLogic.Services.OrderService;
using CoffeeShop.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    /// <summary>
    /// provides all operations for the order controller
    /// </summary>
    public class OrderController : Controller
    {

        private readonly IOrderService _orderService;

        /// <summary>
        /// initializes the constructor
        /// </summary>
        /// <param name="orderService"></param>
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlaceOrder()
        {
            return View();
        }

        /// <summary>
        /// places the order for the customer
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PlaceOrder(Order order)
        {
            var result = await _orderService.CreateOrder(order);
            var response = new
            {
                result
            };
            return View(response);
        }
    }
}
