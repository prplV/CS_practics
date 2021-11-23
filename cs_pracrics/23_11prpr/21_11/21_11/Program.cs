using System;

namespace prpr_23_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк массива");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов массива");
            int b = int.Parse(Console.ReadLine());

            int[,] array = new int[a, b];

            for (int i = 0; i < a; i++) 
            {
                for (int j = 0; j < b; j++) 
                {
                    array[i, j] = Console.Read();
                }
            }

            Obr(array, a, b);
        }

        static void Obr(int[,] mas, int a, int b) 
        {
            int sum = 0;
            int pr = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == j)
                    {
                        sum += mas[i, j];
                    }
                    else if (i + j == b - 1)
                    {
                        pr *= mas[i, j];
                    }
                }

            }
            Console.WriteLine(sum);
            Console.WriteLine(pr);
        }
    }
}
