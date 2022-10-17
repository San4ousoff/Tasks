/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
SumOddNum();

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void SumOddNum ()
{
    int sumOddNum = 0;
    for (int count=0; count<array.Length; count++)
    {
        if (count%2!=0) sumOddNum=sumOddNum+array[count];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях = {sumOddNum}");
}