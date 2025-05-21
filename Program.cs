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
            char[] buffer = new char[10];
            const int passwordLength = 10;
            var random = new Random();
            Console.WriteLine('a' + 1); // gives 98 as 'a' is converted to 97
            Console.WriteLine('a' + 2); // gives 99

            for (var i = 0; i < passwordLength; i++)
            {
                //generate random string of 10 chars
                //write ensures chars on single line
                Console.Write((char)random.Next(97, 122));

                //or

                Console.WriteLine((char)('a' + random.Next(0, 26)));

                //store each letter in buffer
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            //store password from buffer
            var password = new string(buffer);
            Console.WriteLine(password);
        }

    }
}
