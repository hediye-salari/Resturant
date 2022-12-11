using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using DomainModel.BaseModel;
using DomainModel.View_model;

namespace DataAccess.Repositories
{
    public class FoodRepositoryInterFace : Service.IFoodRepository, IDisposable

    {
        private ResturantContext db = new ResturantContext();
        public OperationResult AddNew(Food food)
        {
            OperationResult op = new OperationResult { OperationDate = DateTime.Now, Operation = "Add_new_Food" };
            
                if (db.Foods.Any(x => x.FoodName == food.FoodName))
                {
                    op.Success = false;
                    op.Message = "This FoodName Alredy Exist";
                    return op;
                }
            try
            {
                db.Foods.Add(food);
                db.SaveChanges();
                op.Success = true;
                op.Message = "food added Successfully";
             
                return op;
            }
            catch (Exception ex)
            {
                op.Success = false;
                op.Message = "Add Faeiled" + ex.Message;
                return op;
            }
        }

        public OperationResult Delete(int FoodID)
        {
            OperationResult op = new OperationResult { Operation = "Delete_Food", OperationDate = DateTime.Now };
            try
            {
                var f = db.Foods.FirstOrDefault(x => x.FoodID == FoodID);
                db.Foods.Remove(f);
               
                if (f==null)
                {
                    op.Message = "غذا مورد نظر یافت نشد ";
                        op.Success = false;
                    return op;
                }
                if (f.OrderDetails.Any())
                {
                    op.Message = "این محصول داراری سابقه میباشد و امکان حذف وجود ندارد ";
                    op.Success = false;
                    return op;
                }
                db.SaveChanges();
                op.Success = true;
                op.Message = "حذف غذا با موفقیت انجام شد ";
                return op;
            }
            catch (Exception ex)
            {
                op.Message = "Delete Failed" + ex.Message;
                op.Success = false;
                return op;
               
            }
        }



        public Food Get(int FoodID)
        {
            return db.Foods.FirstOrDefault(x => x.FoodID == FoodID);
        }

        public List<Food> GetAll()
        {
            return db.Foods.ToList();
        }

        public OperationResult Update(Food f)
        {
            OperationResult op = new OperationResult { Operation = "Update_food", OperationDate =DateTime.Now};
            // احتمال اینکه در این نقطه خطایی هم قرار است اتفاق بیافتد به همین دللیل ترای ررا میگذاریم
            // وگرنه فقط در همون نقطه که احتمال ثبت خطا وجود دارد ترای را میگذاریم 
            try
            {
                var food = db.Foods.FirstOrDefault(x => x.FoodID==f.FoodID);
                food.FoodName = f.FoodName;
                food.Ingredients = f.Ingredients;
                food.CategoryID = f.CategoryID;
                food.UnitPrice = f.UnitPrice;
                food.Description = f.Description;
                
                db.SaveChanges();
                op.Success = true;
                op.Message = "ویرایش با موفقیت انجام شد ";
                return op;
            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "به روز رسانی صورت نگرفت" + ex.Message;
                return op;
            }
          
        }
        public void Dispose()
        {
            db.Dispose();
        }
       
        public List<Food> Search(FoodSearchModel sm)
        {
            var q = from item in db.Foods select item;
            //select * from Food  in sql
            if (sm.CategoryID!=null)
            {

                q = q.Where(x => x.CategoryID == sm.CategoryID);
                //select *from food where categoryId=1 in sql 
            }
            if (!string.IsNullOrEmpty(sm.FoodName))
            {
                q = q.Where(x => x.FoodName.StartsWith(sm.FoodName));
                //like n'ch' = product name با ch شروع شود 
            }
            if (!string.IsNullOrEmpty(sm.Ingredients))
            {
                q = q.Where(x => x.Ingredients.Contains(sm.Ingredients));
                //contains وسط و آخر و اول همه را میگردد
            }
            if (sm.UnitpriceFrom!= null)
            {

                q = q.Where(x => x.UnitPrice >= sm.UnitpriceFrom);
                //select *from food where categoryId=1 in sql 
            }
            if (sm.UnitpriceTo != null)
            {

                q = q.Where(x => x.UnitPrice <= sm.UnitpriceTo);
                //select *from food where categoryId=1 in sql 
            }
            return q.ToList();
        }
    }
}

        

