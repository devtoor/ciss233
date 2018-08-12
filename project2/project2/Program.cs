// CISS 233-300: Project 02
// Author:   Jay Morales
// Date:     February 5, 2018
// Project:  Shape Area Calculator
// Purpose:  This program will calculate the areas of six shapes.

using static System.Console;
using static System.Math;

namespace Project02AreaCalculator
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                ShowMenu();
                if (int.TryParse(ReadLine(), out var input))
                {
                    if (input > 0 && input < 7)
                        CalculateArea(input);
                    else
                        if (input == 7)
                        break;
                }
            }
            while (true);

            Clear();
            WriteLine("\n Goodbye!\n");
            Write(" Press any key to end . . .");
            ReadKey();
        }

        private static void ShowMenu()
        {
            Clear();
            WriteLine("\n Shape Area Calcualator");
            WriteLine(" *******************************************************");
            WriteLine("\t1. Circle");
            WriteLine("\t2. Square");
            WriteLine("\t3. Rectangle");
            WriteLine("\t4. Rhombus");
            WriteLine("\t5. Parallelogram");
            WriteLine("\t6. Trapezoid");
            WriteLine("\t7. Exit");
            WriteLine(" *******************************************************");
            Write(" Select a shape type to calculate: ");
        }

        private static void CalculateArea(int shape)
        {
            switch (shape)
            {
                case 1:
                    CalculateCircle();
                    break;
                case 2:
                    CalculateSquare();
                    break;
                case 3:
                    CalculateRectangle();
                    break;
                case 4:
                    CalculateRhombus();
                    break;
                case 5:
                    CalculateParallelogram();
                    break;
                case 6:
                    CalculateTrapezoid();
                    break;
            }
        }

        private static void CalculateCircle()
        {
            const string TYPE = "Circle";

            if (GetInput(TYPE, "the circle's radius", out var radius))
            {
                // Area = PI * radius^2
                ShowResult(TYPE, 3.14 * Pow(radius, 2),
                    $"\tYou've entered {radius} for the radius.");
            }
        }

        private static void CalculateSquare()
        {
            const string TYPE = "Square";

            if (GetInput(TYPE, "one side fo the square", out var side))
            {
                // Area = side^2
                ShowResult(TYPE, Pow(side, 2),
                    $"\tYou've entered {side} for the length of a side.");
            }
        }

        private static void CalculateRectangle()
        {
            const string TYPE = "Rectangle";

            if (GetInput(TYPE, "one side fo the rectangle", out var length))
            {
                if (GetInput(TYPE, "an opposing side of the rectangle", out var width))
                {
                    // Area = length * width
                    ShowResult(TYPE, length * width,
                        $"\tYou've entered {length} for the first side.\n" +
                        $"\tYou've entered {width} for the opposing side.");
                }
            }
        }

        private static void CalculateRhombus()
        {
            const string TYPE = "Rhombus";

            if (GetInput(TYPE, "one diagonal of the rhombus", out var diagonalA))
            {
                if (GetInput(TYPE, "the other diagonal of the rhombus", out var diagonalB))
                {
                    // Area = (diagonal A * diagianal B) / 2
                    ShowResult(TYPE, diagonalA * diagonalB / 2,
                        $"\tYou've entered {diagonalA} for the first diagonal.\n" +
                        $"\tYou've entered {diagonalB} for the second diagonal.");
                }
            }
        }

        private static void CalculateParallelogram()
        {
            const string TYPE = "Parallelogram";

            if (GetInput(TYPE, "the base of the parallelogram", out var baseLength))
            {
                if (GetInput(TYPE, "the heigth of the parallelogram", out var hieght))
                {
                    // Area = base * height
                    ShowResult(TYPE, baseLength * hieght,
                        $"\tYou've entered {baseLength} for the base.\n" +
                        $"\tYou've entered {hieght} for the height.");
                }
            }
        }

        private static void CalculateTrapezoid()
        {
            const string TYPE = "Trapezoid";

            if (GetInput(TYPE, "the large base of the trapezoid", out var largeBase))
            {
                if (GetInput(TYPE, "the small base of the trapezoid", out var smallBase))
                {
                    if (GetInput(TYPE, "the height of the trapezoid", out var hieght))
                    {
                        // Area = height * (large base + small base) / 2
                        ShowResult(TYPE, hieght * (largeBase + smallBase) / 2,
                            $"\tYou've entered {largeBase} for the large base.\n" +
                            $"\tYou've entered {smallBase} for the small base.\n" +
                            $"\tYou've entered {hieght} for the height.");
                    }
                }
            }
        }

        private static bool GetInput(string type, string info, out double input)
        {
            Clear();
            WriteLine($"\n {type} Area Calculator");
            Write($"\n Enter the length of {info} (-1 to exit back to menu): ");
            // Return true if input is valid and greater than -1
            return double.TryParse(ReadLine(), out input) && input > -1;
        }

        private static void ShowResult(string type, double area, string info)
        {
            Clear();
            WriteLine($"\n {type} Area Calculator\n");
            WriteLine(info);
            WriteLine($"\tThe area of your {type.ToLower()} is: {area}");
            Write("\n Press any key to continue!!!");
            ReadKey();
        }
    }
}