using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Programmer : Employee
    {
        public Programmer(string name, int salary) : base(name, salary) { }

        public override int CalculateSalary() { return Salary; }
        public override string DisplayInfo() { return $"Programmer {Name} salary is {CalculateSalary()}"; }
    }
}
