using System;
using System.Configuration.Assemblies;
using System.Globalization;
using practice_dotnet.Math;


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- Write a program to count how many numbers between 
            1 and 100 are divisible by 3 with no remainder. 
            Display the count on the console.*/
            // var count = 0;
            // for (var i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         count++;
            //     }
            // }

            // Console.WriteLine("q1: ", count);

            /*2- Write a program and continuously ask the user to enter a number 
            or "ok" to exit. Calculate the sum of all the previously entered numbers 
            and display it on the console.*/
            // var count = 0;
            // while (true)
            // {
            //     Console.WriteLine("Enter number: ");
            //     string? s = Console.ReadLine();

            //     if (s != "ok")
            //     {
            //         var number = int.Parse(s);
            //         count += number;
            //         continue;
            //     }
            //     Console.WriteLine("q2: " + count);
            //     break;
            // }
            // ;

            /*3- Write a program and ask the user to enter a number. 
            Compute the factorial of the number and print it on the console. 
            For example, if the user enters 5, the program should 
            calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/

            // Console.WriteLine("Enter number: ");
            // string? s = Console.ReadLine();
            // var num = int.Parse(s);
            // var count3 = 1;

            // for (var i = num; i > 0; i--)
            // {
            //     count3 *= i;
            // }
            // Console.WriteLine("q3: " + num + "!: " + count3);

            /*4- Write a program that picks a random number between 1 and 10. 
            Give the user 4 chances to guess the number. 
            If the user guesses the number, display “You won"; otherwise, display “You lost". 
            (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/

            var random = new Random();
            var randNum = random.Next(1, 11);
            Console.WriteLine(randNum);
            var count4 = 1;
            while (true)
            {
                Console.WriteLine("Guess num:");
                string? s4 = Console.ReadLine();
                var guess = int.Parse(s4);
                if (guess != randNum && count4 < 4)
                {
                    count4++;
                    continue;
                }
                else if (guess == randNum)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost");
                    break;
                }
            }

            /*5- Write a program and ask the user to enter a series of numbers separated by comma. 
            Find the maximum of the numbers and display it on the console. 
            For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/

            Console.WriteLine("Enter string of numbers: ");
            string? numString = Console.ReadLine();
            var numArray = numString.Split(",");

            // Step 1: Create a new array to hold the integers
            int[] intArray = new int[numArray.Length];

            // Step 2: Loop through each string in numArray
            for (int i = 0; i < numArray.Length; i++)
            {
                // Step 3: Trim whitespace and parse to int
                string trimmed = numArray[i].Trim();
                int number = int.Parse(trimmed);

                // Step 4: Store the integer in intArray
                intArray[i] = number;
            }

            // step 1-4 in one step
            var intArray = numArray.Select(s => int.Parse(s.Trim())).ToArray();

            // find the max number
            var maxNum = intArray.Max();
            Console.WriteLine("q5: " + maxNum);


        }


    }
}
