using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers", numbers);
            PrintNumbers("Even Numbers", numbers.Where(n => IsEven(n)));
            PrintNumbers("Odd Numbers", numbers.Where(IsOdd));
        }

        private static void PrintNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();

            Console.Write($"{title} : [");
            foreach (var number in numbers)
            {
                Console.Write($" {number}");
            }

            Console.WriteLine(" ]");
        }

        private static bool IsEven(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }

        private static bool IsOdd(int number)
        {
            if (number % 2 != 0) return true;
            else return false;
        }
    }
}