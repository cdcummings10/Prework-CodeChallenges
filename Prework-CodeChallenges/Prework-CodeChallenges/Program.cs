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
            int[] param1 = new int[] { 6, 4, 4, 1, 3 };
            Console.WriteLine("Code Challenge 1");
            Console.WriteLine($"Array input [ 6, 4, 4, 1, 3 ], Int input 4");
            Console.WriteLine($"Answer: {ArrayMaxResult(param1, 4)}");



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


    }
}
