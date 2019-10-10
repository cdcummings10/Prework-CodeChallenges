using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chal1input = new int[] { 6, 4, 4, 1, 3 };
            Console.WriteLine("Code Challenge 1");
            Console.WriteLine($"Array input [ 6, 4, 4, 1, 3 ], Int input 4");
            Console.WriteLine($"Answer: {ArrayMaxResult(chal1input, 4)}");

            Console.WriteLine("\n Code Challenge 2");
            Console.WriteLine($"Answer: {CheckIfLeapYear(1604)}");
            Console.WriteLine($"Answer: {CheckIfLeapYear(1800)}");
            Console.WriteLine($"Answer: {CheckIfLeapYear(2000)}");

            int[] chal3inputCorrect1 = new int[] { 1, 3, 2 };
            int[] chal3inputCorrect2 = new int[] { 0, 0, 0, 0 };
            int[] chal3inputIncorrect1 = new int[] { 1, -3, 2 };
            int[] chal3inputIncorrect2 = new int[] { 4, 5, 6 };
            Console.WriteLine("\n Code Challenge 3");
            Console.WriteLine($"Answer: [1, 3, 2] {CheckIfPerfectSequence(chal3inputCorrect1)}");
            Console.WriteLine($"Answer: [0, 0, 0, 0] {CheckIfPerfectSequence(chal3inputCorrect2)}");
            Console.WriteLine($"Answer: [1, -3, 2] {CheckIfPerfectSequence(chal3inputIncorrect1)}");
            Console.WriteLine($"Answer: [4, 5, 6] {CheckIfPerfectSequence(chal3inputIncorrect2)}");

            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine("\n Code Challenge 4");
            Console.WriteLine($"Answer: Sum of Rows =  {String.Join(", ", CalcSumOfRows(myArray))}");


            Console.ReadLine();
        }

        private static int ArrayMaxResult(int[] array, int pick)
        {
            int timesSeen = 0;
            foreach (int number in array)
            {
                if (number == pick)
                {
                    timesSeen++;
                }
            }
            return pick * timesSeen;
        }

        private static string CheckIfLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                return $"{year} is a leap year.";
            }
            else
            {
                return $"{year} is not a leap year.";
            }
        }

        private static string CheckIfPerfectSequence(int[] array)
        {
            int sum = 0;
            int product = 1;
            foreach (int num in array)
            {
                if (num >= 0)
                {
                    sum += num;
                    product *= num;
                }
                else
                {
                    return "Not a perfect sequence, contains negative value.";
                }
            }
            if (sum == product)
            {
                return "Array is a perfect sequence";
            }
            else
            {
                return "Array is not a perfect sequence.";
            }
        }

        private static int[] CalcSumOfRows(int[,] arr)
        {
            int[] answer = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i , j];
                }
                answer[i] = sum;
            }
            return answer;
        }
    }
}
