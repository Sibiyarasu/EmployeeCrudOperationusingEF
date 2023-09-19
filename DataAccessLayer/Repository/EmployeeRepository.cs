using DataAccessLayer.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly Context _Context;
        public EmployeeRepository(Context context)
        {
            _Context = context;
        }
       public  void DeleteEmployee(int id)
        {
            _Context.Database.ExecuteSqlRaw($"exec dbo.DeleteEmployee '{id}'");

        }

       public  List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                var list = _Context.EmployeeInfo.FromSqlRaw<EmployeeModel>($"dbo.GetEmployee").ToList();

                return list;

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception EX)
            {
                throw EX;
            }

        }

     

         public void InsertEmployee(EmployeeModel model)
        {
            try
            {

                _Context.Database.ExecuteSqlRaw($"exec dbo.InsertEmployeeInfo '{model.Name}','{model.Dept}','{model.Salary}','{model.DOB}','{model.WorkType}'");
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


      public   void UpdateEmployee(EmployeeModel model)
        {
            try
            {
                _Context.Database.ExecuteSqlRaw($"exec dbo.UpdateEmployee '{model.Id}','{model.Name}','{model.Dept}','{model.Salary}','{model.DOB}'");

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

      public   EmployeeModel GetEmployeeById(int id)
        {
            try
            {
                var res = _Context.EmployeeInfo.FromSqlRaw($"exec dbo.GetEmployeeByid '{id}'").ToList();
                return res.FirstOrDefault();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

       public  List<EmployeeDropDownModel> GetEmployeeWorkType()
        {
            try
            {
                 var res=_Context.EmployeeWorkType.FromSqlRaw<EmployeeDropDownModel>($"exec dbo.GetEmployeeWorkType").ToList();
                return res;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
    }

       
    }

