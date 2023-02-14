// =====================Задача 54================================
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
                Console.Write($"{array[i, j],4} |");
            else Console.WriteLine($"{array[i, j],4}  ]");
        }
    }
}

int[,] SortRowsArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            for (int k = 0; k < array2D.GetLength(1); k++)
                if (array2D[i, k] < array2D[i, j])
                {
                    int temp = array2D[i, j];
                    array2D[i, j] = array2D[i, k];
                    array2D[i, k] = temp;
                }
    return array2D;
}


Console.Write("Введите количество строк в массиве: ");
int rowSize = UserInput();
if (rowSize <= 0) IncorrectValue();
Console.Write("Введите количество столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();
Console.Write("Введите минимальное значение: ");
int minValue = UserInput();
Console.Write("Введите максимальное значение: ");
int maxValue = UserInput();

int[,] matrix = MatrixCreate(rowSize, columnsSize, minValue, maxValue);
Console.WriteLine("Заданный массив: ");
PrintMatrix(matrix);

int[,] sortRows = SortRowsArray(matrix);
Console.WriteLine("Отсортированный массив:");
PrintMatrix(sortRows);