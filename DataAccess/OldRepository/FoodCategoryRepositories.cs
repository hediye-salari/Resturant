using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.Repositories
{
    public class FoodCategoryRepositories
    {
        private ResturantContext db = new ResturantContext();
        public void Delete(int FoodCategoryID)
        {
            FoodCategory FoodCategory = db.FoodCategories.FirstOrDefault(emp => emp.FoodCategoryID == FoodCategoryID);
            db.FoodCategories.Remove(FoodCategory);
            db.SaveChanges();
        }

        public List<FoodCategory> GetAll()
        {
            return db.FoodCategories.ToList();
        }

      public  FoodCategory Get(int FoodCategoryID)
        {
            FoodCategory FoodCategory = db.FoodCategories.FirstOrDefault(emp => emp.FoodCategoryID == FoodCategoryID);
            return FoodCategory;
        }

        public int Add(FoodCategory emp)
        {
            db.FoodCategories.Add(emp);
            db.SaveChanges();
            return emp.FoodCategoryID;
        }

        public void Update(FoodCategory newFoodCategory)
        {
            FoodCategory oldFoodCategory = db.FoodCategories.FirstOrDefault(x => x.FoodCategoryID == newFoodCategory.FoodCategoryID);
            oldFoodCategory.CategoryName = newFoodCategory.CategoryName;
            oldFoodCategory.Description = newFoodCategory.Description;
            db.SaveChanges();


        }
    }
}

