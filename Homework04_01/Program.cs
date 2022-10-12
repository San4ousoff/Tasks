/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
int result = 1;

void View() // метод void чисто для практики 
{
    Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {result}");
}

for(int count=1; count<=B; count++) // применение цикла for
{
    result = result * A;
}
View(); // вызов метода


