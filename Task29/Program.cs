/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); 
(1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/
Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array=GetArray(rows, colums, 0, 10);
PrintArray(array);
//int[,] newArray=EditArray(array);
Console.WriteLine($"Сумма элементов главной диагонали равна {SumElement(array)}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue,maxValue+1);
        }
    } 
    return result;
}

void PrintArray (int[,] inArray)
{
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SumElement(int[,] inArray)
{
    int sumEl = 0;
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
          if (i==j) sumEl+=inArray[i,j];
//      inArray[i,j]=Math.Pow(inArray[i,j],2);
        }
    }
    return sumEl;
}