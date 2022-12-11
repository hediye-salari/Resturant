using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.View_model
{
  public class OrderDetailesSearchModel
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public string FoodName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
