/* 
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];
    for (int i=0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue,maxValue+1);
        Console.Write($"{rez[i]} ");
    }
    return rez;
}

Console.WriteLine("Введите длину массива, минимальное и максимальное значение элементов: ");
Console.Write($"Длина массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write($"Значение минимального элемента массива: ");
int minEl = int.Parse(Console.ReadLine()!);
Console.Write($"Значение максимального элемента массива: ");
int maxEl = int.Parse(Console.ReadLine()!);

Console.Write("Исходный массив: ");
int[] array = GetArray(length,minEl,maxEl);

Console.Write($"\nЗадайте искомое число от {minEl} до {maxEl}: ");
int num = int.Parse(Console.ReadLine()!);

Console.Write($"\nВ заданном массиве есть искомое число? ");
for(int i=0; i<array.Length; i++)
{
    array[i] = num;
    Console.Write("Да");
    break;
}