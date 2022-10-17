/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();

//Console.WriteLine("Введите длину массива, минимальное и максимальное значение элементов.");
Console.Write($"Длина массива: ");
int length = int.Parse(Console.ReadLine()!);
//Console.Write($"Значение минимального элемента массива: ");
//double minEl = double.Parse(Console.ReadLine()!);
//Console.Write($"Значение максимального элемента массива: ");
//double maxEl = double.Parse(Console.ReadLine()!);
Console.Write("Исходный массив: ");
double[] array = GetArray(length);
Console.Write($"\nМаксимальный элемент массива = {MaxNum (array)}");
Console.Write($"\nМинимальный элемент массива = {MinNum (array)}");
Console.Write($"\nРазница между максимальным и минимальным значениями массива = {MaxNum (array) - MinNum (array)}");

double[] GetArray(int size)
{
    double[] arr=new double[size];
    Random rand = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = Math.Round((1+rand.NextDouble()*(1+100)),1);
        Console.Write ($"{arr[i]} ");
    }
    return arr;
}

double MaxNum (double[] arr)
{
    double maxEl = arr [0];
    for (int i=1; i<array.Length; i++)
    {
        if (arr[i]>maxEl) maxEl=arr[i];
    }
    return maxEl;
}

double MinNum (double[] arr)
{
    double minEl = arr [0];
    for (int i=1; i<array.Length; i++)
    {
        if (arr[i]<minEl) minEl=arr[i];
    }
    return minEl;
}
