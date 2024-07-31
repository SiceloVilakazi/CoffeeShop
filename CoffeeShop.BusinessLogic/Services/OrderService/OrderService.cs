using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.BusinessLogic.Services.OrderService
{
    /// <summary>
    /// Implements the order service
    /// </summary>
    public class OrderService :BaseService, IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        /// <summary>
        /// initializes the constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="orderRepository"></param>
        public OrderService(IUnitOfWork unitOfWork, IOrderRepository orderRepository) : base(unitOfWork)
        {
            _orderRepository = orderRepository;
        }

        /// <summary>
        /// creates a new order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public async Task<Order> CreateOrder(Order order)
        {
           try
            {
                await _orderRepository.AddAsync(order);
                await UnitOfWork.CommitAsync();
                return order;
              }
              catch (Exception ex)
            {
                throw new Exception(ex.Message);
              }
        }

        /// <summary>
        /// gets a specific order by customer Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Order> GetOrderByCustomerId(int id)
        {
            return await _orderRepository.GetByExpressionAsync(x => x.CustomerID == id);
        }
    }
}
