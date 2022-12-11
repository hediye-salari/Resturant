using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.Repositories
{
    public class OrderDetailsRepositories
    {

        private ResturantContext db = new ResturantContext();
        public void Delete(int OrderDetailsID)
        {
            OrderDetails OrderDetails = db.OrderDetails.FirstOrDefault(emp => emp.OrderDetailsID == OrderDetailsID);
            db.OrderDetails.Remove(OrderDetails);
            db.SaveChanges();
        }

        public List<OrderDetails> GetAll()
        {
            return db.OrderDetails.ToList();
        }

      public  OrderDetails Get(int OrderDetailsID)
        {
            OrderDetails OrderDetails = db.OrderDetails.FirstOrDefault(emp => emp.OrderDetailsID == OrderDetailsID);
            return OrderDetails;
        }

        public int Add(OrderDetails emp)
        {
            db.OrderDetails.Add(emp);
            db.SaveChanges();
            return emp.OrderDetailsID;
        }

        public void Update(OrderDetails newOrderDetails)
        {
            OrderDetails oldOrderDetails = db.OrderDetails.FirstOrDefault(x => x.OrderDetailsID == newOrderDetails.OrderDetailsID);
            oldOrderDetails.Quantity = newOrderDetails.Quantity;
            oldOrderDetails.UnitPrice = newOrderDetails.UnitPrice;
            db.SaveChanges();

        }

        public static implicit operator OrderDetailsRepositories(OrderDetailesRepositoryInterFace v)
        {
            throw new NotImplementedException();
        }
    }
}
