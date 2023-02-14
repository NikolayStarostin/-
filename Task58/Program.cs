// =====================Задача 58================================
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// ==============================================================


void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1)
                Console.Write($"{array[i, j],4}  |");
            else Console.WriteLine($"{array[i, j],4}  ]");
        }
    }
}

int[,] multMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowsMatrixC, columnsMatrixC;
    if (matrixA.GetLength(0) > matrixB.GetLength(0))
        rowsMatrixC = matrixB.GetLength(0);
    else
        rowsMatrixC = matrixA.GetLength(0);
    if (matrixA.GetLength(1) > matrixB.GetLength(1))
        columnsMatrixC = matrixB.GetLength(1);
    else
        columnsMatrixC = matrixA.GetLength(1);
    
    int[,] matrixC = new int[rowsMatrixC, columnsMatrixC];
 
    for (int i = 0; i < rowsMatrixC; i++)
    {
        for (int j = 0; j < columnsMatrixC; j++)
        { 
            for (int k = 0; k < rowsMatrixC; k++)
            {
                matrixC [i, j] += matrixA [i, k] * matrixB [k, j];
            }
        }
    }
    return matrixC;
}


Console.Write("Введите количество строк в матрице А: ");
int rowsMatrixA = UserInput();
if (rowsMatrixA <= 0) IncorrectValue();
Console.Write("Введите количество столбцов в матрице А: ");
int columnsMatrixA = UserInput();
if (columnsMatrixA <= 0) IncorrectValue();
Console.Write("Введите минимальное значение элементов матрицы А: ");
int minValueMatrixA = UserInput();
Console.Write("Введите максимальное значение элементов матрицы А: ");
int maxValueMatrixA = UserInput();

Console.Write("Введите количество строк в матрице B: ");
int rowsMatrixB = UserInput();
if (rowsMatrixB <= 0) IncorrectValue();
Console.Write("Введите количество столбцов в матрице B: ");
int columnsMatrixB = UserInput();
if (columnsMatrixB <= 0) IncorrectValue();
Console.Write("Введите минимальное значение элементов матрицы B: ");
int minValueMatrixB = UserInput();
Console.Write("Введите максимальное значение элементов матрицы B: ");
int maxValueMatrixB = UserInput();

int[,] matrixA = MatrixCreate(rowsMatrixA, columnsMatrixA, minValueMatrixA, maxValueMatrixA);
Console.WriteLine();
Console.WriteLine("Матрица А: ");
PrintMatrix(matrixA);

int[,] matrixB = MatrixCreate(rowsMatrixB, columnsMatrixB, minValueMatrixB, maxValueMatrixB);
Console.WriteLine();
Console.WriteLine("Матрица B: ");
PrintMatrix(matrixB);

int [,] matrixC = multMatrix (matrixA, matrixB);
Console.WriteLine();
Console.WriteLine ($"Результирующая матрица:");
PrintMatrix(matrixC);