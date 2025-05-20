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
          

            var firstName = "Mosh";
            String lastName = "Joe";
            //method 1
            var fullName = firstName + "" + lastName;

            //method 2
            var myFullName = string.Format("My fullname is  {0} {1}", firstName, lastName);
            var names = new string[3] { "J", "K", "Q" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // verbatim string to avoid formatting errors
            var text = @"Hi John
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text);

        }
    }
}

