/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();

Console.Write("Введите угловой коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите действительное число b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите угловой коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите действительное число b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Result(k1, b1, k2, b2);

double EquationLineX(double a1, double c1, double a2, double c2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 1);
    return x;
}

double EquationLineY(double a1, double c1, double a2, double c2)
{
    double y = Math.Round(k1 * (b2 - b1) / (k1 - k2) + b1, 1);
    return y;
}

void Result(double a1, double c1, double a2, double c2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают, точек пересечения бесконечное количество.");
    }
    else
    {
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, точки пересечений отсутствуют.");
        }
        else
        {
            Console.Write($"Координаты точки пересечения заданных прямых: ({EquationLineX(k1, b1, k2, b2)}; {EquationLineY(k1, b1, k2, b2)})");
        }
    }
}