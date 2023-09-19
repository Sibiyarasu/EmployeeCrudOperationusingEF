using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public  interface IEmployee
    {
        public List<EmployeeModel> GetAllEmployee();
        public EmployeeModel GetEmployeeById(int id);
        public void InsertEmployee(EmployeeModel model);
        public void UpdateEmployee(EmployeeModel model);

        public void DeleteEmployee(int id);

        public List<EmployeeDropDownModel> GetEmployeeWorkType();



    }
}
