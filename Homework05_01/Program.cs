/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();

//Console.WriteLine("Введите длину массива, минимальное и максимальное значение элементов.");
Console.Write($"Длина массива: ");
int length = int.Parse(Console.ReadLine()!);
//Console.Write($"Значение минимального элемента массива: ");
//int minEl = int.Parse(Console.ReadLine()!);
//Console.Write($"Значение максимального элемента массива: ");
//int maxEl = int.Parse(Console.ReadLine()!);
Console.Write("Исходный массив: ");
int[] array = GetArray(length,100,1000);
EvenNum();

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] rez = new int[size];
    for (int i=0; i<size; i++)
    {
        rez[i] = new Random().Next(minValue,maxValue);
        Console.Write($"{rez[i]} ");
    }
    return rez;
}

void EvenNum()
{
    int count = 0;
    foreach(int el in array)
    {
        if (el%2==0) count++;
    }
    Console.WriteLine($"\nКоличество четных чисел в массиве = {count}");
}