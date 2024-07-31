using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Entities
{
    public class ItemSize
    {
        public int ItemSizeID { get; set; }
        public int ItemID { get; set; }
        public string Size { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
