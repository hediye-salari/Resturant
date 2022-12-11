using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
  public  class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int OrderID { get; set; }
        public Order Orders { get; set; }
        public Food Food { get; set; }
    }
}
