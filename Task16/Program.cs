/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {CountNum(num)} цифр(ы)");


int CountNum (int number)
{
    int count = 0;
    while (number>0)
    {
        number = number/10;
        count++;
    }
    return count;
}