/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

Console.Write("Введите неотрицательное число M: ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Введите неотрицательное число N: ");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Функция Аккермана A({numberM},{numberN}) = {AckermannFunc(numberM, numberN)}");

int AckermannFunc (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunc(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunc(M - 1, AckermannFunc(M, N - 1));
return AckermannFunc(M, N);
}