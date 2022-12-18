using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInheritance
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
            Name = "Loc";
            FirstName = "Nguyen";
            Salary = 11;
        }
        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }
        public void Work()
        {
            Console.WriteLine("I'm working");
        }
        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}