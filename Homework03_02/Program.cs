/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();

Console.Write("Введите координату X точки А: ");
int xA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки А: ");
int yA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки А: ");
int zA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату X точки B: ");
int xB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки B: ");
int yB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки B: ");
int zB = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((xA-xB),2)+Math.Pow((yA-yB),2)+Math.Pow((zA-zB),2)); //формула нахождения
                                                                                        //длины отрезка

Console.WriteLine
($"Длина отрезка АВ равна {Math.Round(result,2)}");