using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.Infrastructure.Repositories
{
    /// <summary>
    /// Implements the customer loyalty repository
    /// </summary>
    public class CustomerLoyaltyPointsRepository : BaseRepository<CustomerLoyaltyPoints>, ICustomerLoyaltyPointsRepository
    {
        /// <summary>
        /// initializes the constructor
        /// </summary>
        /// <param name="dBContext"></param>
        public CustomerLoyaltyPointsRepository(CoffeeShopDBContext dBContext) : base(dBContext)
        {
        }
    }
}
