using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.Infrastructure.Repositories
{
    /// <summary>
    /// Implements the item size repository
    /// </summary>
    public class IItemSizeRepository : BaseRepository<ItemSize>, IitemSizeRepository
    {
        /// <summary>
        /// initializes the constructor
        /// </summary>
        /// <param name="dBContext"></param>
        public IItemSizeRepository(CoffeeShopDBContext dBContext) : base(dBContext)
        {
        }
    }
}
