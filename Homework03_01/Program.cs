/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

Console.Write("Введите любое целое пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int number = num;
int count = 0;

int LenghtNumber (int num)  //воспользовался функцией (методом), тк обратил внимание, что один и тот же код
                            //повторяется два раза - поиск длины введённого числа
{
    while (num > 0)
    {
    count++;
    num = num/10;
    };
return(count);
}

LenghtNumber (num); //первый вызов функции 
/*while (num > 0)
{
count++;
num = num/10;
};
//Console.WriteLine(count);*/


while (count!=5) //проверяем длину числа на соответствие условиям задачи
{
count=0;
Console.WriteLine("Криворукий! Пя-ти-знач-но-е! Вводи заново.");
num = int.Parse(Console.ReadLine()!);
number=num;
LenghtNumber (num); //второй вызов функции
/*    while (num > 0) 
    {
    count++;
    num = num/10;
    };*/
};

//Console.WriteLine(count); //верно
//Console.WriteLine(num); //=0
//Console.WriteLine(number); //введенное пятизначное число - дальше работаем с ним

//Console.WriteLine(number%100000/10000); //работа над поиском числа на определенной позиции
//Console.WriteLine(number%10);
//Console.WriteLine(number%10000/1000);
//Console.WriteLine(number%100/10);

if ((number%100000/10000==number%10) && (number%10000/1000==number%100/10)) //условие полиндрома
{
    Console.WriteLine("Вы ввели полиндром!");
}
else
{
    Console.WriteLine("Это не полиндром!");
};