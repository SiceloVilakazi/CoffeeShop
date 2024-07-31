using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.Infrastructure.Repositories
{
    /// <summary>
    /// implements the item repository
    /// </summary>
    internal class ItemRepository : BaseRepository<Item>, IitemRepository
    {
        /// <summary>
        /// Initializes the constructor
        /// </summary>
        /// <param name="dBContext"></param>
        public ItemRepository(CoffeeShopDBContext dBContext) : base(dBContext)
        {
        }
    }
}
