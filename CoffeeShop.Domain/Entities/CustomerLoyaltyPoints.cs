using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Entities
{
    public class CustomerLoyaltyPoints
    {
        public int CustomerLoyaltyPointsID { get; set; }
        public int CustomerID { get; set; }
        public int LoyaltyTypeID { get; set; }
        public int Points { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
