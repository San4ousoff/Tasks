/* 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();

double number = new Random().Next(0,10);
//Console.WriteLine(number); - проверка ввода

double count = 1;

Console.Write("В диапазоне от 1 до " + number + " находятся следующие чётные числа: ");
if (number % 2 == 0)
{
    while (count < number) 
    {
        if (count % 2 == 0) Console.Write(count + ", ");
    count++;
    }
    Console.Write(count);
}
else
{
    while (count < number-1) 
    {
        if (count % 2 == 0) Console.Write(count + ", ");
    count++;
    }
    Console.Write(count);
}