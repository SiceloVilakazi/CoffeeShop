

using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Generic;
using CoffeeShop.Domain.Interfaces;

namespace CoffeeShop.BusinessLogic.Services.ItemService
{
    /// <summary>
    /// implements the item service
    /// </summary>
    public class ItemService :BaseService, IitemService
    {
        private readonly IitemRepository _itemRepository;

        /// <summary>
        /// Used to inject the item repository
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="itemRepository"></param>
        public ItemService(IUnitOfWork unitOfWork, IitemRepository itemRepository) : base(unitOfWork)
        {
            _itemRepository = itemRepository;
        }

        /// <summary>
        /// adds an item to the database
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        public async Task<string> AddItem(Item newItem)
        {
           try
            {
                await _itemRepository.AddAsync(newItem);
                await UnitOfWork.CommitAsync();
                return "Item added successfully";
            }
            catch
            (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// gets a list of all items
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _itemRepository.GetAllAsync();
        }

        /// <summary>
        /// gets a single item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Item> GetItemById(int id)
        {
            return await _itemRepository.GetByExpressionAsync(x => x.ItemID == id);
        }
    }
}
