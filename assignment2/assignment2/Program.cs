using static System.Console;
using static System.Double;
using static System.Math;

/*
 * CISS 233-300: Assignment 02
 * 
 * Author:      Jay Morales
 * Date:        January 23, 2018
 * Project:     Console Application to calculate area of a circle
 * Purpose:     This program demonstrate my solution to Assignment 02.
 *
 */

namespace assignment2   
{
    class CircleAreaCalculator
    {
        private double radius;

        // Valid input > 0
        private CircleAreaCalculator GetInput()
        {
            Write("Enter radius of the circle: ");

            while (!TryParse(ReadLine(), out radius) || radius <= 0)
            {
                WriteLine("\nInvalid input . . . ");
                Write("Enter radius of the circle: ");
            }
            return this;
        }

        private CircleAreaCalculator CalculateAndDisplay()
        {
            if (radius > 0)
            {
                WriteLine("\nThe area of the circle is -> {0:F}",
                    PI * Pow(radius, 2));
            }
            return this;
        }

        private bool ReDoAgain()
        {
            char input;

            do
            {
                Write("\nDo you want to calculate another (y/n): ");
                input = ReadKey()
                    .KeyChar;
                WriteLine();
            }
            while (input != 'n' && input != 'N' && input != 'y' && input != 'Y');

            return input == 'y' || input == 'Y';
        }

        private static void Main()
        {
            while (new CircleAreaCalculator()
                .GetInput()
                .CalculateAndDisplay()
                .ReDoAgain())
            {
                WriteLine("\n==================================\n");
            }
        }
    }
}