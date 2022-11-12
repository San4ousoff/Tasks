/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

Console.Write("Введите натуральное минимальное число диапазона: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите натуральное максимальное число диапазона: ");
int n = int.Parse(Console.ReadLine()!);

SumElList(m, n, 0);

void SumElList (int minEl, int maxEl, int sum)
{
    if (minEl > maxEl) 
    {
        Console.WriteLine($"Сумма натуральных элементов в заданном промежутке = {sum}"); 
        return;
    }
    sum = sum + (minEl++);
    SumElList(minEl, maxEl, sum);
}