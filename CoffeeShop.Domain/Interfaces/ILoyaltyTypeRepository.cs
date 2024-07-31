
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;

namespace CoffeeShop.Domain.Interfaces
{
    /// <summary>
    /// Implements the loyalty type repository
    /// </summary>
    public interface ILoyaltyTypeRepository : IAsyncRepository<LoyaltyTypes>
    {
    }
}
