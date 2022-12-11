using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Service;
using DomainModel.BaseModel;
using DomainModel.Models;
using DomainModel.View_model;

namespace DataAccess.Repositories
{
    public class CustomerRepositoryInterFace : Service.ICustomerRepositories, IDisposable
    {
        private ResturantContext db = new ResturantContext();

        public OperationResult AddNew(Cusstomer customer)
        {
            OperationResult op = new OperationResult { Operation = "Add_new_Customer",OperationDate=DateTime.Now };
            if (db.Customers.Any(x=>x.FirstName==customer.FirstName))
            {
                op.Success = false;
                op.Message = "This FoodName Alredy Exist ";
                return op;
            }
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                op.Success = true;
                op.Message = "Employee added ";
                return op;

            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "Add Faeiled " + ex.Message;
                return op;
            }
        }

        public OperationResult Delete(int CustomerID)
        {
            OperationResult op = new OperationResult { Operation = "Delete_Customer", OperationDate = DateTime.Now };
            try
            {
                var c = db.Customers.FirstOrDefault(x => x.CustomerID == CustomerID);
                db.Customers.Remove(c);
                if (c == null)
                {
                    op.Message = "not found Food";
                    op.Success = false;
                    return op;
                }
                if (c.Orders.Any())
                {
                    op.Message = "این مشتری داراری سابقه میباشد و امکان حذف وجود ندارد ";
                    op.Success = false;
                    return op;
                }
                db.SaveChanges();
                op.Success = true;
                op.Message = "Delete successfully";
                return op;
            }
            catch (Exception ex)
            {
                op.Message = "Delete Failed" + ex.Message;
                op.Success = false;
                return op;

            }
        }

        

        public Cusstomer Get(int CustomerID)
        {
            return db.Customers.FirstOrDefault(x => x.CustomerID == CustomerID);
        }

        public List<Cusstomer> GetAll()
        {
            return db.Customers.ToList();
        }

        public OperationResult Update(Cusstomer c)
        {
            OperationResult op = new OperationResult { Operation = "Add_new_Customer", OperationDate = DateTime.Now };
            try
            {
                var cusstomer = db.Customers.FirstOrDefault(x => x.CustomerID == c.CustomerID);
                cusstomer.FirstName = c.FirstName;
                cusstomer.LastName = c.LastName;
                cusstomer.Mobile = c.Mobile;
                cusstomer.Tel = c.Tel;
                db.SaveChanges();
                return op;
            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "update failed" + ex.Message;
                return op;
            }

        }
        public bool LoginCustomer(string FirstName, string LastName)
        {
            bool Exists = db.Customers.Any(emp => emp.FirstName == FirstName && emp.LastName == LastName);
            return Exists;
        }

        public void Dispose()
        {
            db?.Dispose();
        }

        public List<Cusstomer> Search(CustomerSearchModel sm)
        {
            var q = from item in db.Customers select item;

            //select from* course
            if (!string.IsNullOrEmpty(sm.FirstName))
            {
                q = q.Where(x => x.FirstName.StartsWith(sm.FirstName));
            }
            if (!string.IsNullOrEmpty(sm.LastName))
            {
                q = q.Where(x => x.LastName.StartsWith(sm.LastName));
            }
            if (!string.IsNullOrEmpty(sm.Mobile))
            {
                q = q.Where(x => x.Mobile.StartsWith(sm.Mobile));
            }
            if (!string.IsNullOrEmpty(sm.Tel))
            {
                q = q.Where(x => x.Tel.StartsWith(sm.Tel));
            }
             return q.ToList();
        }
    }
}

