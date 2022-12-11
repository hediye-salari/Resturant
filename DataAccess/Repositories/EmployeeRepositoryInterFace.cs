using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Service;
using DomainModel.BaseModel;
using DomainModel.Models;
using DomainModel.View_model;

namespace DataAccess.Repositories
{
  public class EmployeeRepositoryInterFace : Service.IEmployeeRepository,IDisposable
    {
       private ResturantContext db = new ResturantContext();
        public OperationResult AddNew(Employee employee)
        {
            OperationResult op = new OperationResult { Operation = "Add_New_Employee", OperationDate = DateTime.Now };
            if (db.Employees.Any(x => x.FirstName == employee.FirstName))
            {
                op.Success = false;
                op.Message = "این کارمند وجود دارد  ";
                return op;
            }
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                op.Success = true;
                op.Message = "کارمند اضافه شد  ";
                return op;

            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "کارمند وارد نشد  " + ex.Message;
                return op;
            }
        }
  

        public OperationResult Delete(int EmployeeID)
        {
            OperationResult op = new OperationResult { Operation = "Delete_Customer", OperationDate = DateTime.Now };
            try
            {
                var e = db.Employees.FirstOrDefault(x => x.EmployeeID == EmployeeID);
                db.Employees.Remove(e);
                if (e == null)
                {
                    op.Message = "کارمند مورد نظر یافت نشد ";
                    op.Success = false;
                    return op;
                }
                if (e.Orders.Any())
                {
                    op.Message = "این کارمند داراری سابقه میباشد و امکان حذف وجود ندارد ";
                    op.Success = false;
                    return op;
                }
                db.SaveChanges();
                op.Success = true;
                op.Message = "حذف با موفقیت انجام شد ";
                return op;
            }
            catch (Exception ex)
            {
                op.Message = "حذف با خطا مواجه شد " + ex.Message;
                op.Success = false;
                return op;

            }
        }
   
        public Employee Get(int EmployeeID)
        {
            return db.Employees.FirstOrDefault(x => x.EmployeeID == EmployeeID);
        }
        public Employee GetEmployeeByUserName(string UserName)
        {
            Employee employee = db.Employees.FirstOrDefault(emp => emp.UserName == UserName);
            return employee;
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public OperationResult Update(Employee e)
        {
            OperationResult op = new OperationResult { Operation = "update-Employee", OperationDate = DateTime.Now };
            try
            {
                var Employee = db.Employees.FirstOrDefault(x => x.EmployeeID == e.EmployeeID);
                Employee.FirstName = e.FirstName;
                Employee.LastName = e.LastName;
                Employee.Mobile = e.Mobile;
                Employee.UserName = e.UserName;
                Employee.Password = e.Password;
                db.SaveChanges();
                return op;
            }
            catch (Exception ex)
            {

                op.Success = false;
                op.Message = "به روز رسانی صورت نگرفت " + ex.Message;
                return op;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
        //برای لاگین باید یک تابع بنویسیم که دو تا مقدارد داشته باشد 
        //که اگر مقدارش برابر ربا مقدارد وروردی ها باشد 
        //مقدار ترو رو برگردونه 
        public bool Login(string FirstName,string LastName)
        {
            bool Exists = db.Employees.Any(emp => emp.FirstName == FirstName && emp.LastName == LastName);
            return Exists;
        }

        public List<Employee> Search(EmployeeSearchModel sm)
        {
            var q = from item in db.Employees select item;
            if (!string.IsNullOrEmpty(sm.FirstName))
            {
                q = q.Where(x => x.FirstName.StartsWith(sm.FirstName));
            }
            if (!string.IsNullOrEmpty(sm.LastName))
            {
                q = q.Where(x => x.LastName.StartsWith(sm.LastName));
            }
            if (!string.IsNullOrEmpty(sm.UserName))
            {
                q = q.Where(x => x.UserName.StartsWith(sm.UserName));
            }

            if (!string.IsNullOrEmpty(sm.Password))
            {
                q = q.Where(x => x.Password.StartsWith(sm.Password));
            }
            if (!string.IsNullOrEmpty(sm.Mobile))
            {
                q = q.Where(x => x.Mobile.StartsWith(sm.Mobile));
            }
              return q.ToList();
        }
    }
}
