using CoffeeShop.Domain.Generic;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.BusinessLogic.Services.CustomerLoyaltyPoints
{
    /// <summary>
    /// Implements the customer loyalty service
    /// </summary>
    public class CustomerLoyaltyPointsService : BaseService, ICustomerLoyaltyPointsService
    {
        private readonly ICustomerLoyaltyPointsRepository _customerLoyaltyPointsRepository;
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// initializes the constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="customerLoyaltyPointsRepository"></param>
        /// <param name="customerRepository"></param>
        public CustomerLoyaltyPointsService(IUnitOfWork unitOfWork, ICustomerLoyaltyPointsRepository customerLoyaltyPointsRepository, ICustomerRepository customerRepository) : base(unitOfWork)
        {
            _customerLoyaltyPointsRepository = customerLoyaltyPointsRepository;
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// Adds new customer loyalty points
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        public async Task<Domain.Entities.CustomerLoyaltyPoints> AddCustomerLoyaltyPointsAsync(int customerId, int points)
        {
            try
            {
               var newPoints= await _customerLoyaltyPointsRepository.AddAsync(new Domain.Entities.CustomerLoyaltyPoints
                {
                    CustomerID = customerId,
                    Points = points
                });
                await UnitOfWork.CommitAsync();
                return newPoints;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// gets a list of customer loyalty points
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>

        public async Task<Domain.Entities.CustomerLoyaltyPoints> GetCustomerLoyaltyPointsAsync(int customerId)
        {
            return await _customerLoyaltyPointsRepository.GetByExpressionAsync(x => x.CustomerID == customerId);
        }

        /// <summary>
        /// calculates monetary value for each customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<decimal> GetMonetaryValueForCustomerPoints(int customerId)
        {
            var customers = await _customerRepository.GetAllAsync();
            var customerPoints = new List<dynamic>();
            var cashPrice = 0;
            foreach (var customer in customers)
            {
                var points = await _customerLoyaltyPointsRepository.ListByExpressionAsync(x => x.CustomerID == customer.CustomerID);
                customerPoints.Add(new
                {
                    CustomerID = customer.CustomerID,
                    CustomerName = customer.Name,
                    Points = points.Count(),
                    cashPrice = convertPointsToMoney(points.Count())
                });
            }
            return cashPrice;
        }

        /// <summary>
        /// gets a list of total points per customer
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<dynamic>> GetTotalPointsPerCustomer()
        {
           var customers  =await _customerRepository.GetAllAsync();
            var customerPoints = new List<dynamic>();
            foreach (var customer in customers)
            {
                var points = await _customerLoyaltyPointsRepository.ListByExpressionAsync(x => x.CustomerID == customer.CustomerID);
                customerPoints.Add(new
                {
                    CustomerID = customer.CustomerID,
                    CustomerName = customer.Name,
                    Points = points.Count()
                });
            }
            return customerPoints;  
        }

        /// <summary>
        /// converts points to 50% of monetary value
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        private decimal convertPointsToMoney(int points)
        {
            decimal money = points * 0.5m;
            return money;
        }
    }
}
