using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

/*
What is a Collection
    - Collections are classes that we can use to store a collection of objects
    - Not limited to one type of objects
    - No size constraints, It can grow in size as we add more elements
Why do we need Collection
    - Store, manage and manipulate groups of objects more efficiently
    - Adding, Deleting, Replacing, Searching, Copying
Non Generic Collection: Can store any type of objects
Generic Collection: Limited to one type of objects
*/

namespace MyCollection
{
    public class MyNonGenericCollection
    {
        public static void Print()
        {
            Console.WriteLine("==============Non Generic Collection==============");
            MyArrayList();
            MyHashTable();
        }
        static void MyArrayList()
        {
            // Declaring an Array List
            Console.WriteLine("==============Array List==============");
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(12.12);
            myArrayList.Add(42);
            myArrayList.Add(52);

            // Delete element by specific VALUE from the array list
            myArrayList.Remove(52);
            // Delete element by specific INDEX from the array list
            myArrayList.RemoveAt(0);
            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                } 
            }
            Console.WriteLine("Sum {0}", sum);
        }
        static void MyHashTable()
        {
            Console.WriteLine("==============Hash Table==============");
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 76);
            Student student3 = new Student(3, "Clara", 43);
            Student student4 = new Student(4, "Steve", 55);

            studentsTable.Add(student1.StudentId, student1);
            studentsTable.Add(student2.StudentId, student2);
            studentsTable.Add(student3.StudentId, student3);
            studentsTable.Add(student4.StudentId, student4);

            // Student storedStudent1 = (Student)studentsTable[student1.StudentId];
            // Console.WriteLine("{0}-{1}-{2}", storedStudent1.StudentId, storedStudent1.Name, storedStudent1.GPA);

            // foreach (DictionaryEntry entry in studentsTable)
            // {
            //     Student temp = (Student) entry.Value;
            //     Console.WriteLine("{0}-{1}-{2}", temp.StudentId, temp.Name, temp.GPA);
            // }

            foreach (Student item in studentsTable.Values)
            {
                Console.WriteLine("{0}-{1}-{2}", item.StudentId, item.Name, item.GPA);
                
            }
        }
    }

    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float GPA)
        {
            this.StudentId = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}