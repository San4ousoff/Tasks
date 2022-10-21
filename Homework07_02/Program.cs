/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

[1;7] -> такого числа в массиве нет
*/

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.Write("Введите первый индекс искомого элемента: ");
int iFound = int.Parse(Console.ReadLine()!);
Console.Write("Введите второй индекс искомого элемента: ");
int jFound = int.Parse(Console.ReadLine()!);

CheckElement(array, iFound, jFound);

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

void CheckElement(int[,] inArray, int i, int j)
{
    if (i > inArray.GetLength(0)-1 || j > inArray.GetLength(1)-1)
    {
        Console.WriteLine($"Элемента с индексами [{i}; {j}] в заданном массиве не существует! ");
    }
    else
    {
        Console.WriteLine($"Элемент с индексами [{i}; {j}] равен {inArray[i, j]}");
    }
}