/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray2Dim(array);

double[] arraySum = ArrSum(array);
//Console.Write($"Сумма элементов каждого столбца: ");
//PrintArray1Dim(arraySum);
double[] arithmeticMeanCol = ArithmeticMeanColumns(arraySum, rows);
Console.Write($"\nСреднее арифметическое каждого столбца: ");
PrintArray1Dim(arithmeticMeanCol);

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

void PrintArray2Dim(int[,] inArray)
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

double[] ArrSum(int[,] inArray)
{
    double[] arr = new double[inArray.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        arr[j] = sum;
        sum = 0;
    }
    return arr;
}

double[] ArithmeticMeanColumns(double[] inArray, int row)
{
    double[] result = new double[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = Math.Round(inArray[i] / row,1);
    }
    return result;
}

void PrintArray1Dim(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}; ");
        }
    }
}