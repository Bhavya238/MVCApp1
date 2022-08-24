using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace MVCApp2.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public string EmpGender { get; set; }

        //[ForeignKey("Department1")]
        public int DeptId { get; set; }
    }
}