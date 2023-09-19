using DataAccessLayer;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudOperation.Controllers
{
    public class EmployeeController : Controller

    {
        public IEmployee _Context;
            public EmployeeController(IEmployee context)
        {
            _Context = context;
        }
        // GET: EmployeeController
        public ActionResult List()
        {
            try
            {
                _Context.GetAllEmployee();
                return View("List",_Context.GetAllEmployee());
            }
            catch(Exception ex )
            {
                throw ex ;
            }
            
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            try
            {
                var model = new EmployeeModel();
                model.Type = _Context.GetEmployeeWorkType();
                return View("Create", model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeModel collection)
        {
            try
            {
                
                    _Context.InsertEmployee(collection);
                
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var res= _Context.GetEmployeeById(id);
            return View("Edit",res);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeModel collection)
        {
            try
            {
               
                    _Context.UpdateEmployee(collection);
                    return RedirectToAction(nameof(List));


                
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
          var res=  _Context.GetEmployeeById(id);
            return View("Delete",res);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeModel collection)
        {
            try
            {
                _Context.DeleteEmployee(id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
