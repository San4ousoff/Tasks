/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]
*/
Console.Clear();

int[] array = new int[8];

void FillingArray() // метод заполнения элементов массива случайными числами и вывода массива на экран
{
    for (int i=0; i<8; i++)
    {
        array[i]=new Random().Next(0,100);
        if (i==7) 
        {
            Console.Write($"{array[i]}");
        }
        else 
            Console.Write($"{array[i]}, ");
    }
}

FillingArray();