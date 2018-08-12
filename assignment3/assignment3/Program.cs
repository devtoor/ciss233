using System;
using System.Linq;
using static System.Console;

/*
 * CISS 233-300: Assignment 03
 *
 * Author:      Jay Morales
 * Date:        January 31, 2018
 * Assignment:  Powerball Number Generator
 * Purpose:     This program demonstrate my solution to Assignment03
 *
 */

namespace assignment3   
{
    internal class A02PBallGenerator
    {
        private const int MAX_WHITEBALL = 69;
        private const int MAX_POWERBALL = 26;
        private const int MIN = 1;

        public int[] WhiteBalls { get; } = GetWhiteBalls();

        public int PowerBall { get; } = GetPowerBall();

        private static int[] GetWhiteBalls()
        {
            var set = new int[5];
            var index = 0;
            while (index < 5)
            {
                if (GetBall(new Random().Next(MIN, MAX_WHITEBALL + 1), out var ball, ref set))
                {
                    set[index++] = ball;
                }
            }
            Array.Sort(set);
            return set;
        }

        private static int GetPowerBall()
        {
            return new Random().Next(MIN, MAX_POWERBALL + 1);
        }

        private static bool GetBall(int random, out int ball, ref int[] set)
        {
            if (set.Any(i => i == random))
            {
                ball = 0;
                return false;
            }

            ball = random;
            return true;
        }

        private static void ShowResult(A02PBallGenerator set)
        {
            Clear();
            WriteLine("\n Powerball Numbers:");
            WriteLine(" -----------------------------------------------------------------");
            WriteLine(set);
            Write("\n Press 'Y' to continue, 'N' to end: ");
        }

        public override string ToString()
        {
            return $" Your numbers are: {WhiteBalls[0],2}, {WhiteBalls[1],2}, {WhiteBalls[2],2}, " +
              $"{WhiteBalls[3],2}, {WhiteBalls[4],2}, and your Powerball is: {PowerBall,2}";
        }

        private static void Main()
        {
            char key;
            do
            {
                var set = new A02PBallGenerator();
                do
                {
                    ShowResult(set);
                }
                while ((key = char.ToUpper(ReadKey().KeyChar)) != 'Y' && key != 'N');
            }
            while (key == 'Y');
        }
    }
}