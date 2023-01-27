// =================Задача 31=================================
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// ==========================================================

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
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

void ArrayElemSwap(int[]massive)
{
    for (int i = 0; i < massive.Length; i++)
    massive[i] = massive[i] * -1;
    
}

int[] arr = CreateArrayRndInt(15, -10, 10);
PrintArray(arr);
ArrayElemSwap(arr);
Console.WriteLine();
PrintArray(arr);