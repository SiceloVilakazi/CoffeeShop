using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;

namespace CoffeeShop.Domain.Interfaces
{
    /// <summary>
    /// Implements the customer loyalty points repository
    /// </summary>
    public interface ICustomerLoyaltyPointsRepository : IAsyncRepository<CustomerLoyaltyPoints>
    {
    }
}
