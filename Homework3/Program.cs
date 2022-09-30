/* 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();

double number = new Random().Next(-100,100);
//Console.WriteLine(number); - проверка ввода

if (number % 2 == 0) Console.WriteLine("Число " + number + " чётное"); 
else Console.WriteLine("Число " + number + " нечётное");