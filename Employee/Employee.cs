using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    abstract class Employee
    {
        public string name;
        public int id;
        public string hireDate;

        public Employee() { }

        public Employee(string empName, int empId, string empHireDate)
        {
            name = empName;
            id = empId;
            hireDate = empHireDate;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Hire Date: {0}", hireDate);
        }
    }
}
