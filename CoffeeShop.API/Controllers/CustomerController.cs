﻿using CoffeeShop.BusinessLogic.Services.CustomerService;
using CoffeeShop.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.API.Controllers
{
    /// <summary>
    /// Provides operations to manage customers
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        /// <summary>
        /// Initialises the constructor
        /// </summary>
        /// <param name="customerService"></param>
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Gets a list of all customers
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _customerService.GetAllCustomers();
            return Ok(result);
        }


        /// <summary>
        /// Get customer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _customerService.GetCustomerById(id);
            return Ok(result);
        }

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            var result = await _customerService.AddCustomer(customer);
            return Ok(result);
        }

    }
}
