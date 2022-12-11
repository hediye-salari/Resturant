using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;


namespace DataAccess.Repositories
{
   public class EmployeeRepositories
    {
        private ResturantContext db = new ResturantContext();
        public void Delete(int EmployeeID)
        {
            Employee employee = db.Employees.FirstOrDefault(emp => emp.EmployeeID == EmployeeID);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int EmployeeID)
        {
            Employee employee = db.Employees.FirstOrDefault(emp => emp.EmployeeID == EmployeeID);
            return employee;
        }

        public int Add(Employee emp)
        {

            bool ExistsUserName = db.Employees.Any(e => e.UserName == e.UserName);
            if (ExistsUserName)
            {
                //throw new Exception("UserName Alredy Exist");
                //چون هیچ وقت ایدی منفی وجود ندارد میگیم اگر یوزرنیم وجود داشت مقدار -1000 را برگردون 

                return -1000;
                 //برای زمانیکه ترای کش استفاده نکنیم
            }

            //قبل از اینکه ایمپلویی ثبت شود شرط بررسی گذاشته میشود 
            db.Employees.Add(emp);
            db.SaveChanges();
            return emp.EmployeeID;
        }

        public void Update(Employee newEmployee)
        {
            Employee oldEmployee = db.Employees.FirstOrDefault(x => x.EmployeeID == newEmployee.EmployeeID);
            oldEmployee.FirstName = newEmployee.FirstName;
            oldEmployee.LastName = newEmployee.LastName;
            oldEmployee.Mobile = newEmployee.Mobile;
            oldEmployee.UserName = newEmployee.UserName;
            oldEmployee.Password = newEmployee.Password;
            db.SaveChanges();


        }

       

        public bool login ( string UserName ,string Password)
        {

            bool Exists = db.Employees.Any(emp => emp.UserName == UserName && emp.Password == Password);
            return Exists;
        }
    }
}

