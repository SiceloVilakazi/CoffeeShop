using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.Infrastructure.Repositories
{
    /// <summary>
    /// Implements the loyalty type repository
    /// </summary>
    public class LoyaltyTypeRepository : BaseRepository<LoyaltyTypes>, ILoyaltyTypeRepository
    {
        /// <summary>
        /// initializes the constructor
        /// </summary>
        /// <param name="dBContext"></param>
        public LoyaltyTypeRepository(CoffeeShopDBContext dBContext) : base(dBContext)
        {
        }
    }
}
