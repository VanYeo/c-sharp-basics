using System;
using practice_dotnet.Math;

namespace practice_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            // var numbers = new int[3];
            // numbers[0] = 1;

        }
    }
}

