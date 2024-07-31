using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;

namespace CoffeeShop.Domain.Interfaces
{
    /// <summary>
    /// Implements the item repository
    /// </summary>
    public interface IitemRepository :IAsyncRepository<Item>
    {
    }
}
