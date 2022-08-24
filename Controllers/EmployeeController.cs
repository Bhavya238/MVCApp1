using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using MVCApp.Models;
using MVCApp2.Models;

namespace MVCApp2.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // GET: Employee
        public ActionResult Index(int DeptId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp=>emp.DeptId==DeptId).ToList();
            return View(employees);
        }

        public ActionResult EmpDetails(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee e1 = employeeContext.Employees.Single(emp => emp.EmpId == id);
            return View(e1);
        }
    }
}