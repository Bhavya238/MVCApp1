using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp2.Models;

namespace MVCApp2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DeptList()
        {
            EmployeeContext empContext = new EmployeeContext();
            List<Department> deptList = empContext.Departments.ToList();
            return View(deptList);
        }
    }
}