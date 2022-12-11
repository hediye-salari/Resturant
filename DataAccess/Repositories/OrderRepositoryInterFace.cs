using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;
using DomainModel.BaseModel;
using DomainModel.View_model;

namespace DataAccess.Repositories
{


    public class OrderRepositoryInterFace : Service.IOrderRepository, IDisposable
    {
        private DomainModel.Models.ResturantContext db = new ResturantContext();

        public OperationResult AddNew(Order order)
        {
            OperationResult op = new OperationResult() ;

            op.OperationDate = DateTime.Now;
            op.Operation = "AddNewOrder";
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                op.Success = true;
                op.Message = "ثبت سفارش انجام شد";
                op.RecordID = order.OrderID;
            }
            catch (Exception ex)
            {
                op.Success = false;
                op.Message = "خطا در ثبت" + ex.Message;

            }
            return op;
        }

        public OperationResult Delete(int OrderID)
        {

            OperationResult op = new OperationResult();
            op.RecordID = OrderID;
            op.OperationDate = DateTime.Now;
            op.Operation = "سفارش حذف شد ";
            try
            {
                var o = db.Orders.FirstOrDefault(x => x.OrderID == OrderID);
                var ods = db.OrderDetails.Where(x => x.OrderID == OrderID);
                foreach (var od in ods)
                {
                    db.OrderDetails.Remove(od);
                    db.SaveChanges();
                }
                db.Orders.Remove(o);
                db.SaveChanges();
                op.Success = true;
                op.Message = "داده با موفقیت حذف شد  ";

            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "حذف دیتا با خطا مواجهه شد " + ex.Message;
            }
            return op;

        }


        public Order Get(int OrderID)
        {
            return db.Orders.FirstOrDefault(x => x.OrderID == OrderID);
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public OperationResult Update(Order ord)
        {
            OperationResult op = new OperationResult { OperationDate = DateTime.Now, Operation = "Update_Order" };

            try
            {
                var order = db.Orders.FirstOrDefault(x => x.OrderID == ord.OrderID);

               
                order.Description = ord.Description;
                order.Customer = ord.Customer;
                order.OrderDate = ord.OrderDate;
                db.SaveChanges();
                //op.Success = true;
                //op.Message = "ویرایش با موفقیت انجام شد ";
                return op;
            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "به روز رسانی نا موفق بود" + ex.Message;
                return op;
            }
        }


        public List<Order> Search(OrderSearchModel sm)
        {
            var q = from o in db.Orders select o;
            if (sm.CustomerID!=null)
            {
                q = q.Where(x => x.CustomerID == sm.CustomerID);
            }
            if (sm.EmployeeID != null)
            {
                q = q.Where(x => x.EmployeeID== sm.EmployeeID);
            }
            if (sm.FromDate != null)
            {
                q = q.Where(x => x.OrderDate>=sm.FromDate);
            }
            if (sm.ToDate != null)
            {
                q = q.Where(x => x.OrderDate<= sm.ToDate);
            }
            return q.ToList();
        }

        public OperationResult RegisterOrderItem(OrderDetails od)
        {
            db.OrderDetails.Add(od);
            db.SaveChanges();
            return null;

        }

        public List<OrderDetailesListItem> GetCurrentOrderItems(int OrderID)
        {

            var q = from f in db.Foods
                    join od in db.OrderDetails
                        on f.FoodID equals od.FoodID
                    select new OrderDetailesListItem
                    {
                        OrderID = od.OrderID
                        ,
                        Quantity = od.Quantity
                        ,
                        UnitPrice = od.UnitPrice
                        ,
                        FoodName = f.FoodName
                        ,
                        OrderDetailsID = od.OrderDetailsID
                        ,
                        TotalPrice = od.Quantity * od.UnitPrice
                    };
            //شماره ایدی رو میگیره و اقلام رو بر میگردونه تو دیتیا گرید 
            return q.Where(x => x.OrderID == OrderID).ToList();
        }
        public void Dispose()
        {
            db.Dispose();
        }

      
    }

}  

