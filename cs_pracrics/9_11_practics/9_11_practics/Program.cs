using System;

namespace _9_11_practics
{
    class Program
    {
        static int Math(int a, int b, char c)
        {
            if (c == '+')
            {
                return a + b;
            }
            else if (c == '-')
            {
                return a - b;
            }
            else if (c == '*')
            {
                return a * b;
            }
            else return 0;
        }

        static void Main()
        {
            Console.Write("1 - ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 - ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("math operator - ");
            char s = Convert.ToChar(Console.ReadLine());
            if (Math(q, w, s) != 0) {
                Console.WriteLine(Math(q, w, s));
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
