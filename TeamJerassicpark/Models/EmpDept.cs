using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamJerassicpark.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> emp { get; set; }
        public Department Dept { get; set; }

    }
}