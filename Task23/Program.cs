/* 
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int a = 0; //остаток от деления на 2

int LenghtArr (int number)
{
    int count = 0;
    for (int i=0; number>0; i++)
    {
        number=number/2;
        count=i;
    }
    return count+1;
}

Console.WriteLine (LenghtArr(num));

int[] GetArray (int size)
{
int[]arr = new int [size];
int num = 
    while (num>0)
    {
        a = num%2;
        num = num/2;
        Console.Write(a);
    }
}

//осталось перевернуть последовательность чисел a