using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCollection
{
    public class MyGenericCollection
    {
        public static void Print()
        {
            Console.WriteLine("==============Generic Collection==============");
            var numbers = new List<int>();
            var numbers2 = new List<int>{1, 2, 4, 5};
            // Add, Remove, RemoveAt
            int i = numbers2[0];
            Console.WriteLine(i);
            MyDictionary();
        }
        static void MyDictionary()
        {
            Console.WriteLine("==============Dictionary==============");
            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "David", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };
            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (var emp in employees)
            {
                employeeDictionary.Add(emp.Role, emp);
            }

            Employee employee1 = employeeDictionary["CEO"];
            Console.WriteLine("{0}-{1}-{2}", employee1.Name, employee1.Role, employee1.Salary);
        }
    }

    public class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate*8*5*4*12;
            }
        } 

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}