// =====================Задача 46================================
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
//  1  4  7  2
//  5  9  2  3
//  8  4  2  4

// 1, 7 -> такого элемента в массиве нет
// ==============================================================

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  | ");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("|");
    }
}

void FindPosition(int[,] matrix, int idrows, int idcolumns)
{
    if ((idrows < matrix.GetLength(0)) && (idcolumns <= matrix.GetLength(1)))
        Console.WriteLine($"Элемент [{idrows}, {idcolumns}] -> {matrix[idrows, idcolumns]}");
    else
        Console.WriteLine($"[{idrows}, {idcolumns}] -> такого элемента в массиве нет");
}


Console.Write("Введите строку: ");
int idrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int idcolumns = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(6, 4, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
FindPosition(array2D, idrows, idcolumns);

