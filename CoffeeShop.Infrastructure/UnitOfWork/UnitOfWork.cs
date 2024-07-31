using CoffeeShop.Domain.DBContext;
using CoffeeShop.Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Infrastructure.UnitOfWork
{
    /// <summary>
    /// handles the unit of work functionality
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// declares the db context
        /// </summary>
        private readonly CoffeeShopDBContext _dbContext;

        /// <summary>
        /// initializes the db context
        /// </summary>
        /// <param name="dBContext"></param>
        public UnitOfWork(CoffeeShopDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        /// <summary>
        /// function to commit all the changes
        /// </summary>
        /// <returns></returns>
        public Task CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
