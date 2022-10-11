/*
Напишите программу, которая выводит массив из 8 
элементов, заполненный нулями и единицами в случайном порядке. 
[1,0,1,1,0,1,0,0]
*/
Console.Clear();

int[]arr = new int[8];
ArrRun(arr);

void ArrRun (int[] arrTemp)
{
    for (int count=0; count<arr.Length; count++)
    {
        arr[count]=new Random().Next(0,2);
        Console.Write($"{arr[count]} ");
    }
}