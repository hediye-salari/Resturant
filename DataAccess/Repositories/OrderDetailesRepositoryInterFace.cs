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
    public class OrderDetailesRepositoryInterFace : Service.IOrderDetailesRepository, IDisposable
    {
        private ResturantContext db = new ResturantContext();

        public OperationResult AddNew(OrderDetails OrderDetails)
        {
            OperationResult op = new OperationResult { OperationDate = DateTime.Now, Operation = "Add_New_order" };
            if (db.Orders.Any(x => x.OrderID == OrderDetails.OrderID))
            {
                op.Success = false;
                op.Message = "This OrderDetailes Alredy Exist";
                return op;
            }
            try
            {
                db.OrderDetails.Add(OrderDetails);
                db.SaveChanges();
                op.Success = true;
                op.Message = "OrderDetailes added Successfully";
                return op;
            }
            catch (Exception ex)

            {
                op.Success = false;
                op.Message = "Add Faeiled" + ex.Message;
                return op;


            }
        }

        public OperationResult Delete(int OrderDetailsID)
        {
            OperationResult op = new OperationResult { OperationDate = DateTime.Now, Operation = "Delete_New_order" };
            try
            {
                var od = db.OrderDetails.FirstOrDefault(x => x.OrderDetailsID == OrderDetailsID);
                db.OrderDetails.Remove(od);
                if (od == null)
                {
                    op.Message = "not found OrderDetailes";
                    op.Success = false;
                    return op;
                }
                if (od.Food.any())
                {
                    op.Message = "این محصول داراری سابقه میباشد و امکان حذف وجود ندارد ";
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
                return op; ;
            }
        }



        public OrderDetails Get(int OrderDetailsID)
        {
            return db.OrderDetails.FirstOrDefault(x => x.OrderDetailsID == OrderDetailsID);
        }

        public List<OrderDetails> GetAll()
        {
            return db.OrderDetails.ToList();
        }

        public OperationResult Update(OrderDetails o)
        {
            OperationResult op = new OperationResult { OperationDate = DateTime.Now, Operation = "Delete_New_order" };
            try
            {
                var orderd = db.OrderDetails.FirstOrDefault(x => x.OrderDetailsID == o.OrderDetailsID);
                orderd.Quantity = o.Quantity;
                orderd.UnitPrice = o.UnitPrice;
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

            public void Dispose()
            {
                db.Dispose();
            }

            public List<OrderDetails> Search(OrderDetailesSearchModel sm)
            {
                var q = from item in db.OrderDetails select item;
            if (sm.OrderID == null)
            {
            }
            else
            {
                q = q.Where(x => x.FoodID == sm.OrderID);
            }

            if (sm.Quantity != null)
                {
                    q = q.Where(x => x.Quantity == sm.Quantity);
                }
                if (sm.UnitPrice != null)
                {
                    q = q.Where(x => x.UnitPrice <= sm.UnitPrice);
                }
                if (sm.TotalPrice != null)
                {
                    q = q.Where(x => x.UnitPrice <= sm.TotalPrice);
                }
               

                return q.ToList();
            }

        }
    }

