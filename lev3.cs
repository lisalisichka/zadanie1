using System;

namespace zadanie3
{
    class Program
    {
        static void MinArrayElement(int[] arr)
        {
            Random rand = new Random();

            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = -10 + rand.Next() % 20;
                Console.Write(arr[a] + " | ");
            }
            Console.WriteLine();

            int min = arr[0];
            int modul;

            for (int a = 0; a < arr.Length; a++)
            {
                if (min < 0) min *= -1;

                modul = arr[a];

                if (modul < 0) modul *= -1;

                if (modul < min) min = modul;
            }
            Console.Write(min);
            Console.WriteLine("\n");
        }


        static void UniqueElement(int[] arr)
        {
            Random rand = new Random();

            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = -10 + rand.Next() % 20;
                Console.Write(arr[a] + " | ");
            }
            Console.WriteLine();

            int num = 0;
            int kd = 0;

            Console.Write("Уникальные элементы: ");

            for (int a = 0; a < arr.Length; a++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[a])
                    {
                        count++;
                        num = arr[j];
                    }
                }

                if (count == 1)
                {
                    Console.Write(num + " | ");
                    k++;
                }
                else num = 0;
            }
            if (k == 0) Console.WriteLine("Нет уникальных элементов");
            Console.WriteLine("\n");
        }


        static void DeleteNegative(int[] arr)
        {
            Random rand = new Random();

            int[] arr1 = new int[10];

            for (int a = 0; i < arr.Length; i++)
            {
                arr[a] = -10 + rand.Next() % 20;
                Console.Write(arr[a] + " | ");
            }
            Console.WriteLine();
            Console.Write("Положительные элементы: ");

            for (int a = 0; a < arr.Length; a++)
            {
                if (arr[a] >= 0) arr1[a] = arr[a];
                else continue;
                Console.Write(arr1[a] + " | ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("First: ");
            int[] arr = new int[10];
            MinArrayElement(arr);

            //2
            Console.WriteLine("Second: ");
            UniqueElement(arr);

            //3
            Console.WriteLine("Third: ");
            DeleteNegative(arr);
        }
    }
}