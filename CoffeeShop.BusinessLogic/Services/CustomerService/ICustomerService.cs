using CoffeeShop.Domain.Entities;

namespace CoffeeShop.BusinessLogic.Services.CustomerService
{
    /// <summary>
    /// Implements the customer service
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// gets a list of all customers
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Customer>> GetAllCustomers();

        /// <summary>
        /// gets a customer by given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Customer> GetCustomerById(int id);

        /// <summary>
        /// get customer points by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<dynamic> GetCustomerPointsById(int id);

        /// <summary>
        /// Adds a new customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        Task<string> AddCustomer(Customer customer);
    }
}
