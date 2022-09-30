/* 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

/* Ввод чисел пользователем
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
*/

// Рандомный автоматический ввод, так мне больше нравится
int number1 = new Random().Next(0,100);
int number2 = new Random().Next(0,100);
int number3 = new Random().Next(0,100);
Console.WriteLine("Даны числа: " + number1 + ", " + number2 + ", " + number3);

int[] arr = new int[3] {number1,number2,number3};
int max = arr[0];
int count = 1;

while (count < arr.Length)
{
    if (max < arr[count]) max = arr[count];
    else count++;
}
Console.WriteLine("Максимальное из данных чисел: " + max);