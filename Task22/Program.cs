/* 
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.Clear();

Console.Write($"Введите значение стороны А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите значение стороны B: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"Введите значение стороны C: ");
int c = int.Parse(Console.ReadLine()!);

TrueFalseTriangle(a, b, c);

void TrueFalseTriangle(int a, int b, int c)
{
    if (a<=0 || b<=0 || c<=0) 
    {
        Console.WriteLine("Введено значение меньше или равно нулю!");
    }
    else
    {
        if ((a+b)>c && (a+c)>b && (b+c)>a)
        {
            Console.WriteLine("Треугольник существует!");
        }
        else
        {
            Console.WriteLine("Треугольник не существует!");
        }
    }
}