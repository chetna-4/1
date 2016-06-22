using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CONTROLLER1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes";
            emp.Salary = 14000;
            employees.Add(emp);
            return employees;
        }
    }
}