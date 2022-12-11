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
   public interface IEmployeeRepository
    {
        OperationResult Delete(int EmployeeID);
        OperationResult Update(Employee e);
        OperationResult AddNew(Employee employee);
        Employee Get(int EmployeeID);
        List<Employee> GetAll();
        List<Employee> Search(EmployeeSearchModel sm);
    }
}
