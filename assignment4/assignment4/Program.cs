// CISS 233-300: Assignment 04
// Author:   Jay Morales
// Date:     February 13, 2018
// Project:  Student Grade Graph by Passing in Command Line Arguments
// Purpose:  This program display a graph of student grades.

using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CommandLineGradeGrapher
{
    internal class Program
    {
        private readonly int[] letterGrade;
        private readonly int[] grade;

        private Program(IReadOnlyList<string> args)
        {
            letterGrade = new int[5];
            grade = new int[args.Count];

            for (var i = 0; i < args.Count; i++)
            {
                if (int.TryParse(args[i], out var result) && result >= 0 && result <= 100)
                    grade[i] = result;
                else
                    grade[i] = 0;    // Set zero if invalid or out of bounds.
            }
        }
        /*
         * letterGrade[0] = A [90-100]
         * letterGrade[1] = B [80-89]
         * letterGrade[2] = C [70-79]
         * letterGrade[3] = D [60-69]
         * letterGrade[4] = F [0-59]
         */
        private Program GroupCount()
        {
            foreach (var score in grade)
            {
                if (score >= 90 && score <= 100)
                    letterGrade[0]++;
                else if (score >= 80 && score <= 89)
                    letterGrade[1]++;
                else if (score >= 70 && score <= 79)
                    letterGrade[2]++;
                else if (score >= 60 && score <= 69)
                    letterGrade[3]++;
                else
                    letterGrade[4]++;
            }
            return this;
        }

        private void DisplayResult()
        {
            WriteLine($"\n{"",10}Student Math Graph\n");

            for (var i = letterGrade.Max(); i > 0; i--)
            {
                Write($"{i,5} {"|",-5}");

                foreach (var num in letterGrade)
                    Write(num >= i ? $"{"*",-5}" : $"{"",5}");

                WriteLine();
            }

            WriteLine($"{"0",5} |____________________________");
            WriteLine($"{"",11}{"A",-5}{"B",-5}{"C",-5}{"D",-5}{"F",-5}\n\n");
            WriteLine($"{"",5}Class had {letterGrade[0],2} A Grades\n" +
                      $"{"",15}{letterGrade[1],2} B Grades\n" +
                      $"{"",15}{letterGrade[2],2} C Grades\n" +
                      $"{"",15}{letterGrade[3],2} D Grades\n" +
                      $"{"",15}{letterGrade[4],2} F Grades\n");
        }

        public static void Main(string[] args)
        {
            new Program(args)
                .GroupCount()        // Count and group by letter grade
                .DisplayResult();    // Show graph of student grades

            Write($"\n{"",5}Press any key to end.");
            ReadKey();
        }
    }
}