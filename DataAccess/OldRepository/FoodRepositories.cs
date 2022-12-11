using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.Repositories
{
    public class FoodRepositories
    {
        private ResturantContext db = new ResturantContext();
        public void Delete(int FoodID)
        {
            Food Food = db.Foods.FirstOrDefault(emp => emp.FoodID == FoodID);
            db.Foods.Remove(Food);
            db.SaveChanges();
        }

        public List<Food> GetAll()
        {
            return db.Foods.ToList();
        }

      public  Food Get(int FoodID)
        {
            Food Food = db.Foods.FirstOrDefault(emp => emp.FoodID == FoodID);
            return Food;
        }

        public int Add(Food f)
        {
            db.Foods.Add(f);
            db.SaveChanges();
            return f.FoodID;
        }

        public void Update(Food newFood)
        {
            Food oldFood = db.Foods.FirstOrDefault(x => x.FoodID == newFood.FoodID);
            oldFood.FoodName = newFood.FoodName;
            oldFood.UnitPrice = newFood.UnitPrice;
            oldFood.Ingredients = newFood.Ingredients;
            oldFood.Description = newFood.Description;

            db.SaveChanges();


        }
    }
}
