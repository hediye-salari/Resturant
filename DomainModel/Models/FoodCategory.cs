using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
  public class FoodCategory
    {
        public int FoodCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Food> Foods { get; set; }

        public FoodCategory()
        {
            this.Foods = new List<Food>();
        }


    }
}
