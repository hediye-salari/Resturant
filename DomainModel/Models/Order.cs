using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
   public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDescription { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public Cusstomer Customer { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public object Description { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
    }
}
   

