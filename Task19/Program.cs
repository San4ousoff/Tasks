/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/ 
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];
    for (int i=0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{rez[i]} ");
    }
    return rez;
}

Console.WriteLine("Введите длину массива, минимальное и максимальное значение элементов: ");
Console.Write($"Длина массива :");
int length = int.Parse(Console.ReadLine()!);
Console.Write($"Значение минимального элемента массива: ");
int minEl = int.Parse(Console.ReadLine()!);
Console.Write($"Значение максимального элемента массива: ");
int maxEl = int.Parse(Console.ReadLine()!);

//Console.WriteLine();
Console.Write("Исходный массив: ");
int [] array = GetArray(length, minEl, maxEl);

Console.Write("\nНовый массив: ");
int newEl = 0;
foreach(int el in array)
{
    newEl = el * -1;
    Console.Write($"{newEl} ");
}