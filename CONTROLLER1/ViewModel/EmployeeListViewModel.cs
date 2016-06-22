using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CONTROLLER1.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeListViewModel> Employees{ get; set; }
        public string UserName { get; set; } 
    }
}