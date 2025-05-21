using System;
using System.Configuration.Assemblies;
using System.Globalization;
using practice_dotnet.Math;


namespace Conditionals
{
    class Program
    {
        // 1- Write a program and ask the user to enter a number. 
        // The number should be between 1 to 10. 
        // If the user enters a valid number, display "Valid" on the console. 
        // Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        static void ValidateNumber(string[] args)
        {
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine();
            int number = int.Parse(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        //2- Write a program which takes two numbers from the console and displays the maximum of the two.
        static void DisplayMax(string[] args)
        {
            Console.Write("Enter number 1");
            string? input1 = Console.ReadLine();

            Console.Write("Enter number 2");
            string? input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int max = Math.Max(num1, num2);
            Console.WriteLine(max);
        }

        //3- Write a program and ask the user to enter the width and height of an image. 
        // Then tell if the image is landscape or portrait.
        static void ImageOrientation(string[] args)
        {
            Console.Write("Enter width");
            string? input1 = Console.ReadLine();
            int width = int.Parse(input1);

            Console.Write("Enter height");
            string? input2 = Console.ReadLine();
            int height = int.Parse(input2);

            if (height > width)
            {
                Console.WriteLine("It is portrait");
            }
            else
            {
                Console.WriteLine("It is landscape");
            }
        }
        /* 4- Your job is to write a program for a speed camera. 
        For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
        Write a program that asks the user to enter the speed limit. 
        Once set, the program asks for the speed of a car. 
        If the user enters a value less than the speed limit, 
        program should display Ok on the console. If the value is above the speed limit,
        the program should calculate the number of demerit points. 
        For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        If the number of demerit points is above 12, the program should display License Suspended. */

        static void SpeedLimit(string[] args)
        {
            Console.Write("Enter speed limit: ");
            string? input1 = Console.ReadLine();
            var speedLimit = int.Parse(input1);

            Console.Write("Enter speed of car: ");
            string? input2 = Console.ReadLine();
            var carSpeed = int.Parse(input2);

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demeritPoints = Decimal.Round((carSpeed - speedLimit) / 5);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(demeritPoints + " incurred.");
                }
            }


        }
    }
}
