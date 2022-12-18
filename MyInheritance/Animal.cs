using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }
        public virtual void MakeSound()
        {
        }
        public virtual void Eat()
        {
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is NOT HUNGRY");    
            }
        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}