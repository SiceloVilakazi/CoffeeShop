using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Entities
{
    public class LoyaltyTypes
    {
        public int LoyaltyTypeID { get; set; }
        public string Name { get; set; } = null!;
        public int Discount { get; set; }
    }
}
