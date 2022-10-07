/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();

Console.WriteLine("Введите координаты точки А");
Console.Write("Координата X точки А: ");
int XA = int.Parse(Console.ReadLine()!);
Console.Write("Координата Y точки А: ");
int YA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B");
Console.Write("Координата X точки B: ");
int XB = int.Parse(Console.ReadLine()!);
Console.Write("Координата Y точки B: ");
int YB = int.Parse(Console.ReadLine()!);


double AB = Math.Round(Math.Sqrt(Math.Pow((XB-XA),2)+Math.Pow((YB-YA),2)),2);
Console.WriteLine($"Длина отрезка АВ = {AB}");