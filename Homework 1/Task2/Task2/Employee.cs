using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }
        public Employee(string name, int salary)
        {

            Name = name;
            Salary = salary;
        }

        public abstract int CalculateSalary();
        public abstract string DisplayInfo();
    }
    
}
