using System;

namespace _005
{
    class Program
    {
        static bool Is(int n)
        {
            for (int i = 1; i < 21; i++)
                if (n % i != 0)
                    return false;

            return true;
        }

        public static int GetAnswer()
        {
            for (int i = 2520; ; i++)
                if (Is(i))
                    return i;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Answer: {GetAnswer()}");

            Console.Read();
        }
    }
}
