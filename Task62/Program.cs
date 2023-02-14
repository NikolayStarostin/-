// =====================Задача 62================================
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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


int[,] MatrixCreate(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    int k = 1;

    while (k <= rows * columns)
    {
        array[i, j] = k;
        if (i <= j + 1 && i + j < rows - 1)
            ++j;
        else if (i < j && i + j >= rows - 1)
            ++i;
        else if (i >= j && i + j > rows - 1)
            --j;
        else
            --i;
        ++k;
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

Console.Write("Введите размер массива: ");
int size = UserInput();
if (size <= 0) IncorrectValue();
int rows = size;
int columns = size;
int[,] matrix = MatrixCreate(rows, columns);
PrintMatrix(matrix);