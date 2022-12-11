using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Cusstomer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public List<Order> Orders { get; set; }
        public Cusstomer()
        {
            Orders = new List<Order>();
        }

    }
}
