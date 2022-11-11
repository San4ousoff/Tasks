/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива: ");
int minEl = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива: ");
int maxEl = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("Исходный массив: ");
int[,] array = GetArray(rows, colums, minEl, maxEl);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Массив сумм строк исходного массива: ");
int[] sumArray = SumRowArray(array);
PrintOneDimArray(sumArray);
Console.WriteLine();
Console.WriteLine();

int minSumElRow = sumArray.Min();
int indexMinSumElRow = Array.IndexOf(sumArray, minSumElRow);
Console.Write($"Номер строки с наименьшей суммой элементов: {indexMinSumElRow+1}");
Console.WriteLine();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintOneDimArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] SumRowArray(int[,] inArray)
{
    int[] row = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sumR = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumR = sumR + inArray[i, j];
            row[i] = sumR;
        }
    }
    return row;
}