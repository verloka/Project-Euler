using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006
{
    class Program
    {
        static int SumSquares(int num)
        {
            int[] arr = new int[num];

            for (int i = 1; i < num + 1; i++)
                arr[i - 1] = (int)Math.Pow(i, 2);

            return arr.Sum();
        }

        static int SquareSum(int num)
        {
            int[] arr = new int[num];

            for (int i = 1; i < num + 1; i++)
                arr[i - 1] = i;

            return (int)Math.Pow(arr.Sum(), 2);
        }

        static int GetAnswer(int num)
        {
            return SquareSum(num) - SumSquares(num);
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Answer: {GetAnswer(100)}");

            Console.Read();
        }
    }
}
