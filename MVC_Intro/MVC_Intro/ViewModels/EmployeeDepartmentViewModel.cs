using MVC_Intro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Intro.ViewModels
{
    public class employeeDepartmentViewModel
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<employeeDetailViewModel> Employees { get; set; }
    }
}