using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInheritance
{
    public class Trainee:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainee(int workingHours, int schoolHours, string name, string firstName, int salary):base(name, firstName, salary) 
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }        
        public void Learn()
        {
            Console.WriteLine("I am learning for {0} hours!", SchoolHours);
        }
        public new void Work()
        {
            Console.WriteLine("I am working for {0} hours!", WorkingHours);
        }
    }
}