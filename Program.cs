using System;
using System.Configuration.Assemblies;
using practice_dotnet.Math;

namespace practice_dotnet
{
        public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

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

        static void Shipping(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // convvert int to string
            Console.WriteLine(method.ToString());

            // converts string into express into common value
            var methodName = "Express";

            // cast from object to actual enum type shipping method 
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }

        static void Increments(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}. b: {1}", a, b));
        }
    }
}

