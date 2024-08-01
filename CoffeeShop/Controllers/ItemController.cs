using CoffeeShop.BusinessLogic.Services.ItemService;
using CoffeeShop.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    /// <summary>
    /// provides operations for all items
    /// </summary>
    public class ItemController : Controller
    {
        private readonly IitemService itemService;

        /// <summary>
        /// intializes the constructor
        /// </summary>
        /// <param name="itemService"></param>
        public ItemController(IitemService itemService)
        {
            this.itemService = itemService;
        }

        public async Task<IActionResult> Index()
        {
            var result =await itemService.GetAllItems();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// create a new item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(Item item)
        {
            if (ModelState.IsValid)
            {
                await itemService.AddItem(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }
    }
}
