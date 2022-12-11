using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Migrations;
using DomainModel.Models;
using DomainModel.BaseModel;
using DomainModel.View_model;


namespace DataAccess.Service
{
   public  interface ICustomerRepositories
    {

        OperationResult Delete(int CustomerID);
        OperationResult Update(Cusstomer c);
        OperationResult AddNew(Cusstomer cusstomer);
        Cusstomer Get(int CustomerID);
        List<Cusstomer> GetAll();
        List<Cusstomer> Search(CustomerSearchModel sm);
    }
}
