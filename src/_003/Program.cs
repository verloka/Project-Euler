using System;
using System.Numerics;

namespace _003
{
    class Program
    {
        //Fermat's little theorem
        static bool IsPrime(int n)
        {
            int a = n - 2;

            if(2 <= a && a <= (n-1))
            {
                //int ap = Math.Pow(a, n);
                return (Math.Pow(a, n) - a) % n == 0;
            }
            return false;
        }

        static int GetAnswer(int number)
        {
            int i = number - 1;
            int aa = 0;
            while(i > 0)
            {
                if (number % i == 0)
                    if (IsPrime(number))
                        return i;

                i--;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.Write("Enter number: ");
            bool result = int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine($"Largest prime factor of the number {number} is {GetAnswer(number)}");

            /*if (result)
                Console.WriteLine($"Number {number} is {(IsPrime(number) ? "not " : "")}prime");
            else
                Console.WriteLine("Incorrect number");*/

            Console.Read();
        }
    }
}
