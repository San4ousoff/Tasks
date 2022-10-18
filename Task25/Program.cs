/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
Console.Clear();

Console.WriteLine("Введите длину массива, минимальное и максимальное значение элементов.");
Console.Write($"Длина массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write($"Значение минимального элемента массива: ");
int minEl = int.Parse(Console.ReadLine()!);
Console.Write($"Значение максимального элемента массива: ");
int maxEl = int.Parse(Console.ReadLine()!);
Console.Write("Исходный массив: ");
int[] array = GetArray(length,minEl,maxEl);
Console.Write("\nНовый массив: ");
int[] nArray = NewArray(array);

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue+1);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int[] NewArray (int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i=0; i<arr.Length; i++)
    {
        newArr[i] = arr [i];
        Console.Write($"{newArr[i]} ");
    }
    return newArr;
}