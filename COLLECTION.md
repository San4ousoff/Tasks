# Методы для работы с массивами
## Заполнение массивов
**1. Заполнение массива вручную пользователем**

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
**2. Заполнение массива случайными числами**
>Задание: пользователем перед заполнением массива задает его длину и диапазон случайных чисел.

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
## Вывод массива
**1. Вывод массива на экран**
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