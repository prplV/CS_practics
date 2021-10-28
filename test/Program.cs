using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            double d = b*b - 4 * a * c;

            if (d > 0)
            {
                Console.WriteLine($"\n x1 = {(-b + Math.Sqrt(d)) / (2 * a)} \n x2 = {(-b - Math.Sqrt(d)) / (2 * a)}");
            }
            else
            {
                if (d == 0)
                {
                    Console.WriteLine($"\n x = {-b / (2*a)}");
                }
                else
                {
                    Console.WriteLine("Net korney!");
                }
            }
        }
    }
}
