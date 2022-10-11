/*
Напишите программу, которая принимает на вход число и выдает сумму всех чисел от 1 до введённого.
4 -> 1+2+3+4=10
*/
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine ($"Сумма чисел = {GetSumNums(num)}"); // вызов метода

int GetSumNums (int number) // метод суммирования
{
    int sum = 0;
    while(number>0)
    {
        sum = sum + number;
        number--;
    }
    return(sum);
}