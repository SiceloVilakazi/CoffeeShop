using CoffeeShop.Domain.Entities;

namespace CoffeeShop.BusinessLogic.Services.CustomerLoyaltyPoints
{
    /// <summary>
    /// implements the customer loyalty points service
    /// </summary>
    public interface ICustomerLoyaltyPointsService
    {
        /// <summary>
        /// gets each customer's loyalty points by customer id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<Domain.Entities.CustomerLoyaltyPoints> GetCustomerLoyaltyPointsAsync(int customerId);

        /// <summary>
        /// adds loyalty points to a customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        Task<Domain.Entities.CustomerLoyaltyPoints> AddCustomerLoyaltyPointsAsync(int customerId, int points);

        /// <summary>
        /// gets the total points per customer
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<dynamic>> GetTotalPointsPerCustomer();

        /// <summary>
        /// gets the monetary value for customer points
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<decimal> GetMonetaryValueForCustomerPoints(int customerId);
    }
}
