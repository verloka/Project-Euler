using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009
{
    class Program
    {

        //a = 2m + 1
        //b = 2m(m + 1) = 2m^2 + 2m
        //c = 2m^2 + 2m +1

        //a + b + c = 1000
        //(2m + 1) + (2m^2 + 2m) + (2m^2 + 2m +1) = 1000
        //4m^2 + 6m + 2 = 1000
        //4m^2 + 6m - 998 = 0


        static List<double> GetM(int a, int b, int c)
        {
            //b^2 - 4ac
            double D = Math.Pow(b, 2) - 4 * a * c;

            //(-b + D^1/2) / 2a
            double x1 = ((-b) + Math.Sqrt(D)) / 2 * a;
            //(-b - D^1/2) / 2a
            double x2 = ((-b) - Math.Sqrt(D)) / 2 * a;

            return new List<double>
            {
                x1,
                x2
            };
        }


        static Tuple<double, double, double, double> GetAnswer()
        {
            foreach (var m1 in GetM(4, 6, -998))
            {
                int m = 4;

                double a = 2 * m + 1;
                double b = 2 * Math.Pow(m, 2) + 2 * m;
                double c = 2 * Math.Pow(m, 2) + 2 * m + 1;

                if (a + b + c == 1000)
                    return new Tuple<double, double, double, double>(a, b, c, a * b * c);
            }

            return new Tuple<double, double, double, double>(-1, -1, -1, -1);
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
