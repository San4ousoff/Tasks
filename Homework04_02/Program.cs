/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();

// Можно извратиться и сделать ввод случайного числа через метод. Пусть здесь полежит.
/*
int RandomInput () 
{
    int num = new Random().Next(1,1000000);
    return (num);
}
int number = RandomInput();
*/ 

int number = new Random().Next(1,1000000);

int NumberLength (int num) // Метод для поиска количества цифр во входящем числе
{
    int count = 0;
    for (count = 0; num>0; count++)
    {
        num = num/10;
    }
    return count;
}

int SumNum (int num) // Метод для расчета суммы цифр в заданном числе
{
    int sum = 0;
    int count = 1;
    for (count=1;count<=NumberLength(number);count++)
    {
        sum = sum + number%((int)Math.Pow(10,count))/(int)Math.Pow(10,(count-1));
    }
    return sum;
}
Console.WriteLine(number);
// Console.WriteLine($"Длина {number} равна {NumberLength (number)} цифр"); проверка работы метода NumberLength
Console.WriteLine($"Сумма цифр в числе {number} равна {SumNum(number)} ");