using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mo3skarTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mo3skarTask.Controllers
{
    public class HomeController : Controller
    {
        static List<Employee> employeeList = new List<Employee>() {
            new Employee
            { ID=1,EmpName="Alaa",EmailAddress="alaaalmasri272@gmail.com"
                ,BOD=new DateTime(2021, 9, 13),
                Country ="Jordan",Salary=300,isActive=true},
             new Employee
            { ID=2,EmpName="ahmad",EmailAddress="ahmad@gmail.com"
                ,BOD=new DateTime(2021, 8, 13),
                Country ="Jordan",Salary=500,isActive=true},
               new Employee
            { ID=3,EmpName="khaled",EmailAddress="khaled@gmail.com"
                ,BOD=new DateTime(2021, 8, 15),
                Country ="Jordan",Salary=100,isActive=true}

        };
        public IActionResult AllEmployees()
        {

            return View(employeeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employeeList.Add(employee);
            return RedirectToAction("AllEmployees");
        }

        public IActionResult Details(int ID)
        {
            var EmpDetails = (from item in employeeList where item.ID == ID select item).FirstOrDefault();

            return View(EmpDetails);
        }
        [HttpGet]
        public IActionResult Delete(int ID)
        {
            var EmpDetails = (from item in employeeList where item.ID == ID select item).FirstOrDefault();

            return View(EmpDetails);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            if (employeeList.Count<=1)
            {
                employeeList.RemoveAt(0);
                return RedirectToAction("AllEmployees");
            }
            else
            {
                employeeList.RemoveAt(employee.ID);
                return RedirectToAction("AllEmployees");
            }
        }
    }
}