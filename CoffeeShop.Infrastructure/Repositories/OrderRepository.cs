using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.Infrastructure.Repositories
{
    /// <summary>
    /// Implements the order repository
    /// </summary>
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        /// <summary>
        /// initialises the constructor
        /// </summary>
        /// <param name="dBContext"></param>
        public OrderRepository(CoffeeShopDBContext dBContext) : base(dBContext)
        {
        }
    }
}
