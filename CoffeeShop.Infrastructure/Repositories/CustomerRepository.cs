using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.Infrastructure.Repositories
{
    /// <summary>
    /// implements the customer repository
    /// </summary>
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        /// <summary>
        /// initialises the constructor
        /// </summary>
        /// <param name="dBContext"></param>
        public CustomerRepository(CoffeeShopDBContext dBContext) : base(dBContext)
        {
        }
    }
}
