using System;
using System.Collections.Generic;

namespace Loops83
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] myArray = { 69, 21, 16, 04, 1998 };
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            int n = 0;
            while (n < 10)
            {
                Console.WriteLine($"N is {n}");
                n++;
            }

            int secretNo = 1;
            do
            {
                Console.WriteLine("Guess the secret number");
                secretNo = Int32.Parse(Console.ReadLine());
            } while (secretNo != 3);*/

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0)
                {
                    break;
                }
            }

            //LISTS
            List<int> nums = new List<int> { 1, 3, 5, 7, 8 };
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            List<int> Dec = new List<int> { 10, 16, 9, 1998, 6658 };
            foreach (var item in Dec)
            {
                Console.WriteLine(item);
            }
            Dec.Add(12);
            Dec.Add(14);
            Dec.Add(11);

            
            Dec.Reverse();
            Dec.RemoveAt(3);

            Console.WriteLine();
        }
    }
}
