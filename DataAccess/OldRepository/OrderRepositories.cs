using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.Repositories
{
    public class OrderRepositories
    {
        private ResturantContext db = new ResturantContext();
        public void Delete(int OrderID)
        {
            Order Order = db.Orders.FirstOrDefault(emp => emp.OrderID == OrderID);
            db.Orders.Remove(Order);
            db.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

      public  Order Get(int OrderID)
        {
            Order Order = db.Orders.FirstOrDefault(emp => emp.OrderID == OrderID);
            return Order;
        }

        public int Add(Order emp)
        {
            db.Orders.Add(emp);
            db.SaveChanges();
            return emp.OrderID;
        }

        public void Update(Order newOrder)
        {
            Order oldOrder = db.Orders.FirstOrDefault(x => x.OrderID == newOrder.OrderID);
            oldOrder.OrderDate = newOrder.OrderDate;
            oldOrder.OrderDescription = newOrder.OrderDescription;
            db.SaveChanges();


        }
    }
}
