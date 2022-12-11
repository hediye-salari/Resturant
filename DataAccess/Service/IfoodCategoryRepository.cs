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
   public  interface IfoodCategoryRepository
    {
        OperationResult Delete(int CategoryID);
        OperationResult Update(FoodCategory fc);
        OperationResult AddNew(FoodCategory FoodCategory);
         FoodCategory  Get(int CategoryID);
        List<FoodCategory> GetAll();
        List<FoodCategory> Search(FoodCategorySearchModel sm);
    }
}
