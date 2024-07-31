using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;

namespace CoffeeShop.Domain.Interfaces
{
    /// <summary>
    /// implements the customer repository
    /// </summary>
    public interface ICustomerRepository : IAsyncRepository<Customer>
    {
    }
}
