# Методы для работы с массивами
## Заполнение массивов
**1. Заполнение одномерного массива вручную пользователем**

> Задание: пользователь вводит с клавиатуры определенное им количество чисел.

Код метода:
~~~
int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}
~~~
**2. Заполнение одномерного массива случайными числами**
>Задание: пользователь перед заполнением массива задает его длину и диапазон случайных чисел.

Код метода:
~~~
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
~~~
**3. Заполнение двумерного массива случайными числами**
>Задание: пользователь перед заполнением массива задает его длину.

Код метода:
~~~
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue,maxValue+1);
        }
    } 
    return result;
}
~~~

## Вывод массива
**1. Вывод одномерного массива на экран**
>Задание: вывести на экран элементы массива через запятую (последний символ - без запятой)

Код метода:
~~~
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}
~~~
**2. Вывод двумерного массива на экран**
>Задание: вывести на экран элементы массива

Код метода:
~~~
void PrintArray (int[,] inArray)
{
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
~~~