using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;

namespace CoffeeShop.Domain.Interfaces
{
    /// <summary>
    /// Implements the order repository
    /// </summary>
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
