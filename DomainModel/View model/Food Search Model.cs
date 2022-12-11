using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.View_model
{
 public class FoodSearchModel
    {
        // سرچ بر اساس  هر چیزی هست  مسنویسیم 
        public string  FoodName{ get; set; }
        public int? UnitpriceFrom { get; set; }
        public int? UnitpriceTo { get; set; }
        public string Ingredients{ get; set; }
        public int? CategoryID { get; set; }

    }
}
