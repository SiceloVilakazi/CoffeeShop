using CoffeeShop.Domain.Entities;

namespace CoffeeShop.BusinessLogic.Services.ItemService
{
    /// <summary>
    /// implements the item service
    /// </summary>
    public interface IitemService
    {
        /// <summary>
        /// gets a list of all items
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Item>> GetAllItems();

        /// <summary>
        /// get a specific item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Item> GetItemById(int id);

        /// <summary>
        /// adds a new item
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        Task<string> AddItem(Item newItem);
    }
}
