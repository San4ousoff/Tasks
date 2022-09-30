//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = number*-1;
if (number < 0)
{
    while(count >= number)
    {
        Console.WriteLine(number);
        number++;
    }
}
else
{
   while(count <= number)
    {
        Console.WriteLine(count);
        count++;
    } 
}
    