using System;

namespace _007
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

        static int GetAnswer(int num)
        {
            int count = 0;
            for (int i = 0;; i++)
                if(IsPrime(i))
                {
                    count++;
                    if (count == num)
                        return i;
                }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Answer: {GetAnswer(10001)}");

            Console.Read();
        }
    }
}
