using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System;
using System.Diagnostics.Metrics;

double number, minnumber;
string rownumber;
bool isconvertnumber;
int index = 0, amount = 0;
Console.WriteLine("Я нахожу количество нечетных элементов введенной последовательности целых чисел.");


do
{
    do
    {
        do
        {
            Console.WriteLine($"Введите эллемент №{index + 1} последовательности");
            rownumber = Console.ReadLine();
            isconvertnumber = double.TryParse(rownumber, out number);
            if (!isconvertnumber)
            {
                Console.WriteLine("Вы ввели не число");
            }
            else if (number % 2 != 0 & (number + 1) % 2 != 0) // Проверка на вещественное число
            {
                Console.WriteLine("Вы ввели вещественное число , последовательность должна состоят только из целых чисел");
            }
            else if (number % 2 != 0)
            {
                amount++;
                index++;
            }
            else
                index++;
        }
        while (!isconvertnumber);
    }
    while (number != 0);
}
while (number % 2 != 0 & (number + 1) % 2 != 0);
if (index == 1) // был введен только 0   
{
    Console.WriteLine("Ваша последовательность пуста");
}
else
{
    Console.WriteLine($"Ваша последовательность состоит из {index - 1} эллементов");
    Console.WriteLine($"Количество нечетных эллементов {amount}");
}

