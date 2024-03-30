using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary) { }
        public override int CalculateSalary() {  return Salary; }
        public override string DisplayInfo() { return $"Manager {Name} salary is {CalculateSalary()}"; }
    }
}
