using System;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count, number, minnumber;
            string rowcount, rownumber;
            bool isconvertcount, isconvertnumber;
            int index, minindex;
            Console.WriteLine("Введите длину последовательности");
            do // Проверка на отрицательное, вещественное и не число и пустую последовательность
            {
                do
                {
                    do
                    {

                        rowcount = Console.ReadLine();
                        isconvertcount = double.TryParse(rowcount, out count);
                        if (!isconvertcount)
                        {
                            Console.WriteLine("Вы ввели не число");
                            Console.WriteLine("Введите целое положительное число длины последовательности");
                        }
                        else if (count < 0)
                        {
                            Console.WriteLine("Длина последовательности не может быть меньше 0");
                            Console.WriteLine("Введите целое положительное число длины последовательности");
                        }
                        else if (count % 2 != 0 & (count + 1) % 2 != 0)
                        {
                            Console.WriteLine("Вы ввели вещественное число , длина последовательности не может быть вещественным числом");
                            Console.WriteLine("Введите целое положительное число длины последовательности");
                        }
                        else if (count == 0)
                        {
                            Console.WriteLine("Последовательность пуста");
                        }
                    }
                    while (!isconvertcount);
                }
                while (count < 0);
            }

            while (count % 2 != 0 & (count + 1) % 2 != 0);
            if (count != 0)
            {
                do
                {

                    Console.WriteLine($"Введите число элемента №1 последовательности"); // Ввод для первого числа , чтобы присвоить минимальное значение 
                    rownumber = Console.ReadLine();
                    isconvertnumber = double.TryParse(rownumber, out number);
                    if (!isconvertnumber)
                    {
                        Console.WriteLine("Вы ввели не число");
                    }
                }
                while (!isconvertnumber);
                index = 1;
                minnumber = number;
                minindex = index;
                for (index = 2; index <= count; index++) //Ввод для остальных эддементов
                    do
                    {
                        Console.WriteLine($"Введите число элемента №{index} последовательности");
                        rownumber = Console.ReadLine();
                        isconvertnumber = double.TryParse(rownumber, out number);
                        if (!isconvertnumber)
                        {
                            Console.WriteLine("Вы ввели не число");
                        }
                        else if (number < minnumber)
                        {
                            minnumber = number;
                            minindex = index;
                        }

                    }
                    while (!isconvertnumber);
                Console.WriteLine($"Минимальный эллемент последовательности = {minnumber} и его индекс: {minindex}");
            }


        }
    }
}