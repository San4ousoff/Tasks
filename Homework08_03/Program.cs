/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

Console.Write("Введите количество строк массива A: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива A: ");
int columsA = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк массива B: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива B: ");
int columsB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Матрица А: ");
int[,] arrayA = GetArray(rowsA, columsA);
PrintArray(arrayA);

Console.WriteLine("Матрица B: ");
int[,] arrayB = GetArray(rowsB, columsB);
PrintArray(arrayB);

Console.WriteLine("Матрица C (результат перемножения матриц А и В): ");
int[,] arrayC = Multiplication(arrayA, arrayB);
PrintArray(arrayC);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 4);
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

int[,] Multiplication(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] result = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                result[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }
    return result;
}