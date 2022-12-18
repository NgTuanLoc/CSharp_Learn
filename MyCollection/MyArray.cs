using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    - Stores a fixed size sequential collection of elements
    - Only of the same type
    - All kinds of types: int, string, object, ...
    - Great to store a collection of data: same type at contiguous memory locations
*/

namespace MyCollection
{
    public class MyArray
    {
        public static void Print()
        {
            int [] gradesOfMathStudentA = { 12, 1, 3, 34 };
            Console.WriteLine("==============Array==============");
            MyFirstArray();
            UsingLoopForArray();
            MultidimensionalArray();
            JaggedArray();
            Console.WriteLine("Average Score : {0}", UseArrayAsParameter(gradesOfMathStudentA));
            UseParamKeyword("A", "B", "C", "D", "...");
        }

        public static void MyFirstArray()
        {
            Console.WriteLine("==============My First Array==============");
            int [] grades = new int[5];
            grades[0] = 1;
            grades[1] = 2;
            grades[2] = 3;
            grades[3] = 4;

            // Another way of create Array
            int [] gradesOfMathStudentA = { 12, 1, 3, 34 };

            // Another way of create Array
            int [] gradesOfMathStudentB = new int [] { 1, 2, 4, 67 };

            Console.WriteLine(gradesOfMathStudentA[3]);
        }

        public static void UsingLoopForArray()
        {
            Console.WriteLine("==============Using Loop for Array==============");
            int [] listOfNumber = new int[10];

            for (int i = 0; i < listOfNumber.Length; i++)
            {
                listOfNumber[i] = i;
            }

            foreach (var item in listOfNumber)
            {
                Console.WriteLine(item);
            }
        }
        public static void MultidimensionalArray()
        {
            Console.WriteLine("==============MultidimensionalArray==============");
            // Declare 2D Array
            int [,] matrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Central value is {0}", matrix[1, 1]);
        }
        public static void JaggedArray()
        {
            Console.WriteLine("==============Jagged Array==============");
            // Declare jagged array
            int [][] jaggedArray = new int[3][];
            jaggedArray[0] = new int [5];
            jaggedArray[1] = new int [3];
            jaggedArray[2] = new int [2];

            jaggedArray[0] = new int[] {1, 2, 3, 4, 5};
            jaggedArray[1] = new int[] {6, 7, 8};
            jaggedArray[2] = new int[] {9, 10};

            // Alternative way
            int [][] newJaggedArray = new int [][]
            {
                new int [] { 1, 2, 3},
                new int [] { 4, 5}
            };
            Console.WriteLine(jaggedArray[2][1]);

            for (int i = 0; i < jaggedArray.Length; i++)
            {   
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
        }
        static double UseArrayAsParameter(int [] gradeArray)
        {
            // Get Average score
            Console.WriteLine("==============Use Array As Parameter Array==============");
            int size = gradeArray.Length;
            double average = 0;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradeArray[i];
            }
            average = (double)sum/size;
            return average;
        }
        static void UseParamKeyword(params string[] sentences)
        {   
            Console.WriteLine("==============Use Params Keyword==============");
            foreach (var item in sentences)
            {
                Console.WriteLine(item);
            }
        }
    }
}