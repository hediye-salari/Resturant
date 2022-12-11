using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
   public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int UnitPrice { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public int OrderDetailesID { get; set; }

        public Food()
        {
            this.OrderDetails = new List<OrderDetails>();
        }

        public bool any()
        {
            throw new NotImplementedException();
        }

        //public static implicit operator Food(Food v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
