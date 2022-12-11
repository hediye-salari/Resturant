using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;
using DomainModel.BaseModel;
using DomainModel.View_model;

namespace DataAccess.Service
{
    interface IOrderRepository
    {
        OperationResult Delete(int OrderID);
        OperationResult Update(Order ord);
        OperationResult AddNew(Order order);
        Order Get(int OrderID);
        List<Order> GetAll();
        List<Order> Search(OrderSearchModel sm);
        OperationResult RegisterOrderItem(OrderDetails od);
        //این و هر وقت صدا بزنیم میره یه اوردر ایدی میگیره و ایتم های اون اوردر ایدی رو میگیره   
        List<OrderDetailesListItem> GetCurrentOrderItems(int OrderID);
    }
}
