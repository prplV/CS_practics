using System;

namespace prpr_11_11
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            for (int i = 0; i < mass.Length; i++) {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }

            Sort(ref mass);

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
            }
        }

        static void Sort(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++) {
                for (int j = 0; j < mas.Length - 1; j++) {
                    if (mas[j] > mas[j + 1]){
                        int z = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = z;
                    }
                }
            }
        }
        */

        //params
        /*
        static void Addition(params int[] integers) 
        {
            int result = 0; 
            for (int i = 0; i < integers.Length; i++) {
                result += integers[i]; 
            }
            Console.WriteLine(result); 
        }
        static void Main(string[] args)
        { 
            Addition(1, 2, 3, 4, 5); //15
            int[] array = new int[] { 1, 2, 3, 4 }; 
            Addition(array); //10
            Addition(); //0
            Console.ReadLine(); 
        }
        */

        static void Main(string[] args) 
        {
            int max = 0;
            int min = 1000000000;
            Console.Write("Enter number of massive elements - ");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine($"Enter {num} elements of array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array before sort:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("");
            Sort(ref array);

            Console.WriteLine("Array after sort:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("");
            Console.Write($"The summ of array elements = ");
            Console.WriteLine(Sum(array));

            Console.WriteLine("Max | Min");
            MaxMin(ref max, ref min, array);
            Console.Write($"{max} | {min}");
        }

        static int Sum(params int[] sos)
        {
            int s = 0;
            for (int i = 0; i < sos.Length; i++)
            {
                s += sos[i];
            }
            return s;
        }

        static void Sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int z = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = z;
                    }
                }
            }
        }

        static void MaxMin(ref int a, ref int b, params int[] abc)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i] > a)
                {
                    a = abc[i];
                }
            }
            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i] < b)
                {
                    b = abc[i];
                }
            }
        }
    }
}
