/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;

Console.Write($"Список кубов чисел от 1 до введённого числа ({num}) равен: ");
while (count <= num)
{
    if (count == num) 
        Console.Write($"{Math.Pow(count,3)}.");
    else 
        Console.Write($"{Math.Pow(count,3)}, ");
count++;
};