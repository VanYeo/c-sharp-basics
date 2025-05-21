using System;
using System.Configuration.Assemblies;
using System.Globalization;
using practice_dotnet.Math;
using System.Linq;  


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3,7,9,2, 14 };
            // length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 9); 
            Console.WriteLine("Index of 9: " + index);

            //clear numbers from index 0 to 2
            Array.Clear(numbers, 0, 2);

            foreach(var number in numbers)
            {
                Console.WriteLine(number); 
                // gives 0, 0, 9, 2, 14
            }

            //copy
            int[] newArray = new int[3];
            // copy first 3 elements of numbers to newArray
            Array.Copy(numbers, newArray, 3); 

            foreach (var number in newArray)
            {
                Console.WriteLine(number);
                // gives 0, 0, 9
            }

            //sort by ascending order
            Array.Sort(newArray);
           
            foreach (var number in newArray)
            {
                Console.WriteLine(number);
                // gives 0, 0, 9
            }

            //reverse()
            Array.Reverse(newArray);
            foreach (var number in newArray)
            {
                Console.WriteLine(number);
                // gives 9, 0, 0
            }
            


        }


    }
}