using MVC_Intro.Models;
using MVC_Intro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intro.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            dataStoreContext _myEmployeeContext = new dataStoreContext();
            // var query = from c in _myEmployeeContext.Employee

            //       select c;
            // List<Employee> employee = _myEmployeeContext.Employee.OrderBy(async => async.Name).ToList();
            var employeeDepartment = (from emp in _myEmployeeContext.Employee
                                      join dept in _myEmployeeContext.Department
                                      on emp.DepartmentId equals dept.DepartmentId
                                      orderby dept.DepartmentName
                                      select new employeeDetailViewModel
                                      {
                                          Name = emp.Name,
                                          EmployeeId = emp.EmployeeId,
                                          DepartmentName = dept.DepartmentName
                                      }).ToList();
            employeeDepartmentViewModel employeeDetails = new employeeDepartmentViewModel
            {
                Employees = employeeDepartment
            };
            return View(employeeDetails);
        }

        // get 
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(employeeDetailViewModel employeeDetails)
        {
            using (dataStoreContext _context = new dataStoreContext())
            {
                if (ModelState.IsValid)
                {
                    Employee employee = new Employee
                    {
                        Name = employeeDetails.Name,
                        DepartmentId = employeeDetails.DepartmentId
                    };
                    _context.Employee.Add(employee);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(employeeDetails);
        }
        //this is the HttpGET  method for the edit page
        public ActionResult Edit(int employeeId)
        {
            using (dataStoreContext _context = new dataStoreContext())
            {
                var employeeDetails = (from emp in _context.Employee
                                       where emp.EmployeeId == employeeId
                                       select new employeeDetailViewModel
                                       {
                                           Name = emp.Name,
                                           EmployeeId = emp.EmployeeId
                                       }).ToList();

                //Employee employee = _context.Employee.Find(employeeId);
                employeeDepartmentViewModel employeeModel = new employeeDepartmentViewModel
                {
                    Name = employeeDetails.Select(a => a.Name).FirstOrDefault(),
                    //DepartmentName = employeeDetails.Select(a => a.DepartmentName).FirstOrDefault()
                };

                return View(employeeModel);
            }
        }
        [HttpPost]
        public ActionResult Edit(employeeDepartmentViewModel employeeDetails)
        {
            using (dataStoreContext _context = new dataStoreContext())
            {
                var employee = _context.Employee.Find(employeeDetails.EmployeeId);
                var department = _context.Department;
                if (ModelState.IsValid)
                {
                    employee.Name = employeeDetails.Name;
                    //employee.DepartmentName = employeeDetails.DepartmentName;

                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(employeeDetails);
            }
        }

        public ActionResult Delete(int employeeId)
        {
            if (employeeId != 0)
            {
                using (dataStoreContext _context = new dataStoreContext())
                {
                    Employee employee = _context.Employee.Find(employeeId);

                    _context.Employee.Remove(employee);
                    _context.SaveChanges();

                }
            }
            else
            {
                ViewBag.Title = "There was a problem";
            }
            return RedirectToAction("Index");
        }
    }
}

