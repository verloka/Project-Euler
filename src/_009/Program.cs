using System;
using System.Collections.Generic;

namespace _009
{
    class Program
    {

        //Euclid's formula
        //a = m^2 - n^2
        //b = 2mn
        //c = m^2 + n^2

        //a + b + c = 1000
        //k*(m^2 - n^2) + k*(2mn) + k*(m^2 + n^2) = 1000
        //km^2 - kn^2 + 2kmn + km^2 + kn^2 = 1000
        //2km^2 + 2mnk = 1000
        //2km(m + n) = 1000 | : 2
        //km(m + n) = 500   | x = m + n
        //kmx = 500
        // m > n
        // m < x < 2m


        static List<int> GetDeviders(int num)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= num; i++)
                if (num % i == 0)
                    list.Add(i);

            return list;
        }


        static Tuple<int, int, int, int> GetAnswer()
        {
            int num = 500;
            var dividers = GetDeviders(num);

            foreach (var m in dividers)
                foreach (var x in dividers)
                    if( m < x && x < 2*m)
                    {
                        int n = x - m;
                        int k = (num / m) / x;

                        int a = k * (m * m - n * n);
                        int b = k * 2 * m * n;
                        int c = k * (m * m + n * n);

                        if ((a + b + c) == 1000)
                            return new Tuple<int, int, int, int>(a, b, c, a * b * c);
                    }


            return new Tuple<int, int, int, int>(-1, -1, -1, -1);
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            var result = GetAnswer();

            Console.WriteLine($"Answer: {result.Item1} х {result.Item2} х {result.Item3} = {result.Item4}");

            Console.Read();
        }
    }
}
