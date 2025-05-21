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
            // // for/foreach loops
            // for (var i = 1; i <= 10; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // for (var i = 10; i >= 1; i--)
            // {
            //     if (i % 2 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // var name = "John";
            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }
            // //or
            // foreach (var letter in name)
            // {
            //     Console.WriteLine(letter);
            // }

            // var numbers = new int[] { 1, 2, 3, 4 };
            // foreach (var num in numbers)
            // {
            //     Console.WriteLine(num);
            // }

            // //while loop
            // var j = 0;
            // while (j <= 10)
            // {
            //     if (j % 2 == 0)
            //     {
            //         Console.WriteLine(j);
            //         j++;
            //     }
            // }

            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Hi " + input);
                }
            }

            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Hi " + input);
                    continue;
                    //continues from while(true) start of loop
                }
                break;
            }
        }
        
        
    }
}
