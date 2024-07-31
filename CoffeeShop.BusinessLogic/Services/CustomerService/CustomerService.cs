using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.BusinessLogic.Services.CustomerService
{
    /// <summary>
    /// Implements the customer service
    /// </summary>
    public class CustomerService : BaseService ,ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository customerRepository):base(unitOfWork)
        {
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// adds a new customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public async Task<string> AddCustomer(Customer customer)
        {
            try
            {
                await _customerRepository.AddAsync(customer);
                await UnitOfWork.CommitAsync();
                return "Customer added successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// gets a list of all customers
        /// </summary>
        /// <returns>A list of all customers</returns>
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
           return  await _customerRepository.GetAllAsync();
        }

        /// <summary>
        /// gets a customer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a customer by a given Id</returns>
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerRepository.GetByExpressionAsync(x=>x.CustomerID==id);
        }

        /// <summary>
        /// gets customer points by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a customer with their points</returns>
        public async Task<dynamic> GetCustomerPointsById(int id)
        {
            return await _customerRepository.GetByExpressionAsync(x => x.CustomerID == id);
        }
    }
}
