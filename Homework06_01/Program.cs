/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();

Console.Write("Сколько чисел Вы хотите ввести: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = GetArray(num);
Console.Write("Список введённых Вами чисел: ");
PrintArray(array);
Console.Write($"\nКоличество положительных чисел среди введённых Вами чисел - {CountPositiveNum(array)}");

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

void PrintArray(int[] arr)
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

int CountPositiveNum(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}










// // Задать с клавиатуры число элементов массива
//         int n;
//         Console.WriteLine("Введите число элементов массива");
//         n = Convert.ToInt16(Console.ReadLine());
//      // Объявим одномерный массив Data с n-элементами 
//         double [] Data = new double[n];
//         int i = 0;
//        while (i < n)
//         {
//            Console.WriteLine("Введите элемент массива");
//         /* Вводим элементы массива с клавиатуры 
//          * и заполняем ими массив */
//            Data[i] = double.Parse(Console.ReadLine());
//            Console.WriteLine();
//            i++;
//         }
//    // Вывод содержимого массива
//      for (i = 0; i < n; i = i + 1)
//      Console.Write($"{Data[i]} ");
//      Console.ReadKey();

