// =================Задача 30=======================
// Напишите программу, которая выводит массив
// из 8 элементов, заполненный нулями и единицами,
// в случайном порядке.

// [1,0,1,1,0,1,0,0]
// =================================================


int[] arr = CreateArray(8);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// int[] arr = CreateArray(8);
// PrintArray(arr);

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }


// int[] array = new int[8];
// array[0] = 123
// array[1] = 123
// array[2] = new Random().Next(10,100);