using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new [] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            //Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear():");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy():");
            foreach(var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort():");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(another);
            Console.WriteLine("Effect of Reverse():");
            foreach (var n in another)
                Console.WriteLine(n);

            var myList = new List<int>() { 1, 2, 3, 4, };
            myList.Add(1);
            myList.AddRange(new int[3]  { 6, 7 ,8 });
            Console.WriteLine("Effect of Add");
            foreach (var n in myList)
                Console.WriteLine(n);
            Console.WriteLine("Index of 1 is: " + myList.IndexOf(1));
            Console.WriteLine("Index of 1 is: " +myList.LastIndexOf(1));

            Console.WriteLine("Count: " + myList.Count);

            for (int i = 0; i <myList.Count; i++)
            {
                if (myList[i] == 1)
                    myList.Remove(myList[i]);
            }
            foreach (var n in myList)
                Console.WriteLine(n);

            myList.Clear();
            Console.WriteLine("Count: " + myList.Count);
            foreach (var n in myList)
                Console.WriteLine(n);

        }
    }
}
