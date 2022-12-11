using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.Repositories
{
    public class CustomerRepositories
    {
        private ResturantContext db = new ResturantContext();
        public void Delete(int CustomerID)
        {

            Cusstomer Customer = db.Customers.FirstOrDefault(cus => cus.CustomerID == CustomerID);
            db.Customers.Remove(Customer);
            db.SaveChanges();
        }

        public  List<Cusstomer> GetAll()
        {
            return db.Customers.ToList();
        }
      public  Cusstomer Get(int CustomerID)
        {
            Cusstomer Customer = db.Customers.FirstOrDefault(cus => cus.CustomerID == CustomerID);

            return Customer;
        }

        public int Add(Cusstomer cus)
        {
            db.Customers.Add(cus);
            db.SaveChanges();
            return cus.CustomerID;
        }

        public void Update(Cusstomer newCustomer)
        {
            Cusstomer oldCustomer = db.Customers.FirstOrDefault(cus => cus.CustomerID == newCustomer.CustomerID);
            oldCustomer.FirstName = newCustomer.FirstName;
            oldCustomer.LastName = newCustomer.LastName;
            oldCustomer.Mobile = newCustomer.Mobile;
            oldCustomer.Tel = newCustomer.Tel;



        }
        public bool LoginCustomer(string UserName, string Password)
        {

            bool Exists = db.Customers.Any(cust =>cust.FirstName  == UserName && cust.LastName == Password);
            return Exists;
        }
    }
}
