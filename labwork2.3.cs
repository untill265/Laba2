using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace laba2._3__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultrad = 0, resultdegrees, x, n;
            string rowx;
            bool isconvertx;

            do
            {
                Console.WriteLine($"Введите число x");
                rowx = Console.ReadLine();
                isconvertx = double.TryParse(rowx, out x);
                if (!isconvertx)
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
            while (!isconvertx);
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine($"Введите целое число n");
                        rowx = Console.ReadLine();
                        isconvertx = double.TryParse(rowx, out n);
                        if (!isconvertx)
                        {
                            Console.WriteLine("Вы ввели не число");
                        }
                        else if (n % 2 != 0 & (n + 1) % 2 != 0)
                        {
                            Console.WriteLine("Вы ввели вещественное число , n может быть только целым положительным числом");
                        }
                        else if (n < 0)
                        {
                            Console.WriteLine("Вы ввели отрицательное число , n может юыть только целым положительным числом");
                        }
                    }
                    while (!isconvertx);
                }
                while (n % 2 != 0 & (n + 1) % 2 != 0);
            }
            while (n < 0);
            for (int i = 1; i <= n; i++)
            {
                resultrad += Math.Pow(Math.Sin(x), i);
            }
            resultdegrees = (resultrad * 180) / Math.PI;
            Console.WriteLine($"Результат в радианах = {resultrad}");
            Console.WriteLine($"Результат в градусах {resultdegrees}");
        }
    }
}