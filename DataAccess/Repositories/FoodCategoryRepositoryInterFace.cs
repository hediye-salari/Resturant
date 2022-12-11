using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.BaseModel;
using DomainModel.Models;
using DomainModel.View_model;

namespace DataAccess.Repositories
{
    public class FoodCategoryRepositoryInterFace : Service.IfoodCategoryRepository,IDisposable
    {
        private ResturantContext db = new ResturantContext();

        public int FoodCategoryID { get; private set; }

        public OperationResult AddNew(FoodCategory FoodCategory)
        {
            OperationResult op = new OperationResult { Operation = "Add_New_Category", OperationDate = DateTime.Now };

            if (db.FoodCategories.Any(x => x.CategoryName == FoodCategory.CategoryName))
            {
                op.Success = true;
                op.Message = "نام این دسته از قبل وجود دارد";
                return op;
            }
            try
            {
                db.FoodCategories.Add(FoodCategory);
                db.SaveChanges();
                op.Success = true;
                op.Message = "دسته با موفقیت اضافه شد";
                return op;

            }
            catch (Exception ex)
            {
                op.Success = false;
                op.Message = "دسته بندی اضافه نشد" + ex.Message;
                return op;


            }

        }

        public OperationResult Delete(int CategoryID)
        {
            OperationResult op = new OperationResult { Operation = "Delete_Food", OperationDate = DateTime.Now };
            try
            {
                var f = db.FoodCategories.FirstOrDefault(x => x.FoodCategoryID == CategoryID);
                db.FoodCategories.Remove(f);

                if (f == null)
                {
                    op.Message = "غذا مورد نظر یافت نشد ";
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

        public FoodCategory Get(int CategoryID)
        {
            return db.FoodCategories.FirstOrDefault(x => x.FoodCategoryID == CategoryID);
        }

        public List<FoodCategory> GetAll()
        {
            return db.FoodCategories.ToList();
        }

        public OperationResult Update(FoodCategory fc)
        {
            OperationResult op = new OperationResult { OperationDate = DateTime.Now, Operation = "Update_FoodCategories" };
           
            try
            {
                var foodCategory = db.FoodCategories.FirstOrDefault(x => x.FoodCategoryID == fc.FoodCategoryID);

                foodCategory.CategoryName = fc.CategoryName;
                foodCategory.Description = fc.Description;
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
        public void Dispose()
        {
            db.Dispose();
        }

        public List<FoodCategory> Search(FoodCategorySearchModel sm)
        {
            var q = from item in db.FoodCategories select item;
            if (!string.IsNullOrEmpty(sm.CategoryName))
            {
                q = q.Where(x => x.CategoryName.StartsWith(sm.CategoryName));
            }
            if (!string.IsNullOrEmpty(sm.Description))
            {
                q = q.Where(x => x.Description.StartsWith(sm.Description));
            }
            return q.ToList();
        }
    }

}


