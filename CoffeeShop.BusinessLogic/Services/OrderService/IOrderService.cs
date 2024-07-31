using CoffeeShop.Domain.Entities;

namespace CoffeeShop.BusinessLogic.Services.OrderService
{
    /// <summary>
    /// Implements the order service
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// creates a new order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        Task<Order> CreateOrder(Order order);

        /// <summary>
        /// gets a specific order by customer id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Order> GetOrderByCustomerId(int id);
    }
}
