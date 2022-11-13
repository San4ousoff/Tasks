/*
Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"
*/

Console.Clear();

Console.Write("Введите натуральное число больше 1: ");
int n = int.Parse(Console.ReadLine()!);

ListEvenNumbers(1, n);

void ListEvenNumbers (int minEl, int maxEl)
{
    minEl = 1;
    if (maxEl <= minEl) 
    {
        return;
    }
    if (maxEl%2 == 0)
    {
        Console.Write($"{maxEl} ");
        ListEvenNumbers (minEl, maxEl - 2);
    }
    else
    {
        ListEvenNumbers (minEl, maxEl - 1);
    }
}