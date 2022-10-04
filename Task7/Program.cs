/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

// if (num2 == 0) break; 

int a1 = num1 % num2;
//Console.WriteLine(a1);

if (a1 == 0) 
{
Console.WriteLine("Кратно");
} 
else Console.WriteLine($"Некратно. Остаток {a1}.");