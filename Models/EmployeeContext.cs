using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
//using System.Data.Entity;
//using MVCApp2.Models;

namespace MVCApp2.Models
{
    //establishing connection to database---EmployeeContext
    public class EmployeeContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}