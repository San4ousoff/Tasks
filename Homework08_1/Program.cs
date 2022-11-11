/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
Console.WriteLine("Результат работы программы (строки исходного массива упорядочены по убыванию): ");
int[,] sortArray = SortRowArray(array);
PrintArray(sortArray);
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

void SortRow(int[] inRow)
{
    for (int i = 0; i < inRow.Length; i++)
        for (int j = 0; j < inRow.Length - 1; j++)
        {
            if (inRow[j] < inRow[j + 1])
            {
                int temp = inRow[j];
                inRow[j] = inRow[j + 1];
                inRow[j + 1] = temp;
            }
        }
}

int[,] SortRowArray(int[,] inArray)
{
    int[] row = new int[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            row[j] = inArray[i, j];
        SortRow(row);
        Insert(i, row, inArray);
    }
    return inArray;
}

void Insert(int i, int[] inRow, int[,] inArray)
{
    for (int k = 0; k < inRow.Length; k++)
    {
        inArray[i, k] = inRow[k];
    }
}
