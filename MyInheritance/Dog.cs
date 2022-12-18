using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInheritance
{
    public class Dog:Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age):base(name, age)
        {
            IsHappy = true;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wuf!");
        }
        public override void Eat()
        {   
            base.Eat();
        }
    }
}