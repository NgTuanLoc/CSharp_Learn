using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    1. IEnumerable<T> for generic collections
    2. IEnumerable for non generic collections
    IEnumerable contains a single method that you must implement when implementing this interface
    GetEnumerator(), which returns an IEnumerator<T> object
    The returned IEnumerator<T> provides the ability to iterate through the collection by exposing a Current property that points at the object we are currently at in the collection

    When it is recommended to use the IEnumerable interface:
        - Your collection represents a massive database table
        => Do not have to copy the entire thing into memory and cause performance issues in application
    When it is not recommended to use the IEnumerable interface:
        - You need the results right away and are possibly mutating/ editing the objects later on 
        => better to use Array or a List 
*/

namespace MyInheritance
{
    public class MyIEnumerable
    {
        public static void Print()
        {
            Console.WriteLine("=============INumerable=============");
            DogShelter shelter = new DogShelter();

            foreach (MyDog dog in shelter)
            {
                if(!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }else{
                    dog.GiveTreat(1);
                }
            }

            // GetCollection
            Console.WriteLine("=============GetCollection=============");
            IEnumerable<int> myCollection = GetCollection(5);
            foreach (int num in myCollection)
            {   
                Console.WriteLine(num);
            }

            // CollectionSum
            Console.WriteLine("=============CollectionSum=============");
            CollectionSum(myCollection);
        }
        static IEnumerable<int> GetCollection(int option)
        {
            List <int> numberList = new List<int>{1, 2, 3};
            Queue<int> numberQueue = new Queue<int>();

            numberQueue.Enqueue(4);
            numberQueue.Enqueue(5);
            numberQueue.Enqueue(6);

            if(option == 1)
            {
                return numberList;
            } 
            else if (option == 2)
            {
                return numberQueue;
            }
            else{
                return new int[]{7, 8, 9};
            }
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
    class MyDog{
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }
        public MyDog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        public void GiveTreat(int numOfTreats)
        {
            Console.WriteLine("Dog: {0} said wuff {1} times!.", Name, numOfTreats);
        }
    }
    class DogShelter:IEnumerable<MyDog>
    {
        public List<MyDog> dogs;
        public DogShelter()
        {
            dogs = new List<MyDog>
            {
                new MyDog("Casper", false),
                new MyDog("Sif", true),
                new MyDog("Oreo", false),
                new MyDog("Pixel", false),
            };
        }

        IEnumerator<MyDog> IEnumerable<MyDog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    
}