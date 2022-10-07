/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.Clear();

Console.Write("Введите простое число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;

Console.Write($"Таблица квадратов чисел: ");
while (count<=num) 
{
    if (count<num) 
    {
        Console.Write(Math.Pow(count,2) + ", ");
    }
    else Console.Write(Math.Pow(count,2));
    count++;
};
