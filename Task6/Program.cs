/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int num = new Random().Next(100,1000);
int a1 = (num / 100) * 10;
//int a2 = num / 10 % 10;
int a3 = num % 10;
int b2 = a1 + a3;

//Console.WriteLine (num);
//Console.WriteLine (a1);
//Console.WriteLine (a2);
//Console.WriteLine (a3);

Console.WriteLine ($"Двузначное число, полученное из удаления второй цифры в {num} -> {b2}");
//Console.WriteLine ($"{a1}{a3}");
