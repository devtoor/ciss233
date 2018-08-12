using static System.Console;
using static System.ConsoleColor;

/*
 * CISS 233-300: Assignment 01
 *
 * Author:      Jay Morales
 * Date:        January 16, 2018
 * Assignment:  Console App
 * Purpose:     This program demonstrate my solution to Assignment01
 *
 */

namespace assignment1
{
    internal class ConsoleApp
    {
        private void DisplayName()
        {
            WriteLine();
            WriteLine("        J     A      Y     Y ");
            WriteLine("        J    A A     Y     Y ");
            WriteLine("        J   A   A     YYYYYY ");
            WriteLine(" J      J  AAAAAAA         Y ");
            WriteLine(" J      J A       A        Y ");
            WriteLine("  JJJJJJ  A       A   YYYYY  ");
            WriteLine();
        }

        private ConsoleApp ChangeColor()
        {
            BackgroundColor = White;
            ForegroundColor = DarkBlue;
            Clear();
            return this;
        }

        private static void Main()
        {
            new ConsoleApp()
                .ChangeColor()
                .DisplayName();

            Write("Press any key to continue ...");
            ReadKey();
        }
    }
}