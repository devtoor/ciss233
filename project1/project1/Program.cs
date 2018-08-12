using System;
using static System.Console;
using static System.Double;

/*
 * CISS 233-300: Project 01
 * 
 * Author:      Jay Morales
 * Date:        January 20, 2018
 * Project:     Command Line Arguments Calculator
 * Purpose:     This program demonstrate my solution to Project 01
 *
 */

namespace project1  
{
    internal class CommandLineCalculator
    {
        private readonly string[] input;
        private bool isValid = true;
        private Operation operation;
        private double total;

        private enum Operation { Addition, Subtraction };

        private CommandLineCalculator(string[] args)
        {
            input = args;
        }

        private CommandLineCalculator CheckForOperation()
        {
            if (input.Length > 0)
            {
                var lastElement = input[input.Length - 1];

                switch (lastElement)
                {
                    case "+":
                        operation = Operation.Addition;
                        break;
                    case "-":
                        operation = Operation.Subtraction;
                        break;
                    default:
                        isValid = false;
                        break;
                }
            }
            else
            {
                isValid = false;
            }
            return this;
        }

        private CommandLineCalculator Calculate()
        {
            if (isValid && TryParse(input[0], out total))
            {
                for (var i = 1; i < input.Length - 1; i++)
                {
                    if (TryParse(input[i], out var temp))
                    {
                        switch (operation)
                        {
                            case Operation.Addition:
                                total += temp;
                                break;
                            case Operation.Subtraction:
                                total -= temp;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    else
                    {
                        // One of the elements is invalid
                        isValid = false;
                        break;
                    }
                }
            }
            else
            {
                // First element is invalid
                isValid = false;
            }
            return this;
        }

        private void ShowResult()
        {
            if (isValid)
            {
                Write("Output: ");
                for (var i = 0; i < input.Length - 1; i++)
                {
                    if (i != 0)
                    {
                        Write("{0} ", input[input.Length - 1]);
                    }
                    Write("{0} ", input[i]);
                }
                WriteLine("= {0}", total);
            }
            else
            {
                WriteLine("Invalid input . . .");
            }
        }

        private static void Main(string[] args)
        {
            new CommandLineCalculator(args)
                .CheckForOperation()
                .Calculate()
                .ShowResult();

            ReadKey();
        }
    }
}