using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.BaseModel;
using DomainModel.Models;
using DomainModel.View_model;

namespace DataAccess.Service
{
   public interface IOrderDetailesRepository
    {
        OperationResult Delete(int OrderDetailsID);
        OperationResult Update(OrderDetails o);
        OperationResult AddNew(OrderDetails OrderDetails);
        OrderDetails Get(int OrderDetailsID);
        List<OrderDetails> GetAll();
        List<OrderDetails> Search(OrderDetailesSearchModel sm);
    }
}
