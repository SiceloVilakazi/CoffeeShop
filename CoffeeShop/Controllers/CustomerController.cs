using CoffeeShop.BusinessLogic.Services.CustomerService;
using CoffeeShop.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    /// <summary>
    /// Handles all processes related to customers
    /// </summary>
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerService;

        /// <summary>
        /// initializes constructor
        /// </summary>
        /// <param name="customerService"></param>
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// returns the view of the customer
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var customers =await  _customerService.GetAllCustomers();
            return View(customers);
        }

        /// <summary>
        /// returns the view of the customer
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// returns the view to create the customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("")] Customer customer )
        {
            var result = await _customerService.AddCustomer(customer);
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
    }
}
