using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mo3skarTask.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
        public string EmailAddress{ get; set; }
        public decimal Salary { get; set; }
        public DateTime BOD { get; set; }
        public  string Country { get; set; }
        public bool isActive { get; set; }

    }
}
