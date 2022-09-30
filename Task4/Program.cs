// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number<100 || number>1000) 
{
    Console.Write("Введено не трехзначное число");
}
else 
{
    number = number % 10;
    Console.Write(number);
}