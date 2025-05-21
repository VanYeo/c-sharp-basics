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

    public class Person
    {
        public int Age;
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

            // convert int to string
            Console.WriteLine(method.ToString());

            // converts string into express into common value
            var methodName = "Express";

            // cast from object to actual enum type shipping method 
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }

        static void refenceType(string[] args)
        {
            //int: b is a separate copy of a and does not get referenced
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}. b: {1}", a, b));
            //a: 10, b: 11

            //arrarys: both arrays point to the same copy of array in heap
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            // gives both 0
        }

        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            // gives number = 1 as separate copy is made in Increment method

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
            // gives 30 as reference same obj on heap

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

