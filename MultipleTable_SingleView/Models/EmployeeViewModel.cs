using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleTable_SingleView.Models
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Incentive> Incentives { get; set; }
    }
}