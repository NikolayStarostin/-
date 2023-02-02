// =====================Задача 34=================================
// Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// ==============================================================


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
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

int CheckEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr [i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size, 100, 1000);
int evennumber = CheckEvenNumber(arr);
PrintArray(arr);
Console.Write ($" -> {evennumber}");


