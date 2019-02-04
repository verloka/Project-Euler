using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
                return false;

            for (int i = 2; i * i <= num; i++)
                if (num % i == 0)
                    return false;

            return true;
        }

        static double GetAnswer(int num)
        {
            double sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Answer: {GetAnswer(2_000_000)}");

            Console.Read();
        }
    }
}
