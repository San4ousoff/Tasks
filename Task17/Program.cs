/*
Напишите программу, которая выводит массив из 8
элементов, заполненный нулями и единицами в случайном порядке. 
[1,0,1,1,0,1,0,0]
*/
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine()!);

int[]arr = new int[num];
ArrRun(arr);

void ArrRun (int[] arrTemp)
{
    for (int count=0; count<arr.Length; count++)
    {
        arr[count]=new Random().Next(0,2);
        Console.Write($"{arr[count]} ");
    }
}