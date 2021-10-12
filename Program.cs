using System;
using System.Collections.Generic;

namespace Circle_Objects_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> numCircles = new List<Circle>();
            bool runner = true;

            while (runner == true)
            {
                double radius = 0;
                radius = ValidRadius(0);
                Circle circle = new Circle(radius);
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area:          {circle.CalculateFormattedArea()}");
                numCircles.Add(circle);
                runner = GetYesOrNo("Would you like to calculate another circle?");
            }
            Console.WriteLine($"Goodbye. You created {numCircles.Count} Circle objects");
        }
        public static bool GetYesOrNo(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                Console.Write("Y/N? ");
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That input is not valid, please try again.");
                }
            }
        }
        public static double ValidRadius(double x)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter radius: ");
                    x = double.Parse(Console.ReadLine());
                    if (x <= 0)
                    {
                        Console.WriteLine("Needs to be greater than 0");
                        continue;
                    }
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number.");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return x;

        }
    }
}
