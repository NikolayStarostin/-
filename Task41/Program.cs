// =====================Задача 41================================
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// ==============================================================


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение {i} элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int FindPositiveNumbers(int[] arr)
{
    {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.Write("Задайте размер массива: ");
int rate = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(rate);
int positivenumbers = FindPositiveNumbers(array);
Console.WriteLine();
PrintArray(array);
Console.Write($" -> {positivenumbers}");
