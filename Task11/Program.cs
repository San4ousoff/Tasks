/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).
*/
Console.Clear();

Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1) Console.WriteLine("Диапазон X>0, Y>0");
if (num == 2) Console.WriteLine("Диапазон X<0, Y>0");
if (num == 3) Console.WriteLine("Диапазон X<0, Y<0");
if (num == 4) Console.WriteLine("Диапазон X>0, Y<0");
if (num <1 || num>4) Console.WriteLine("Введён неверный номер. Нужно от 1 до 4!");