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
   public interface IFoodRepository
    {

        OperationResult Delete(int FoodID);
        OperationResult Update(Food f);
        OperationResult AddNew(Food food);
        Food Get(int FoodID);
        List<Food> GetAll();
        List<Food> Search(FoodSearchModel sm);


        //int Add(Food f);
        //void Delete(int FoodID);
        //List<Food> GetAll();
        //void Update(Food f);
        //Food Get(int FoodID);

    }
}
