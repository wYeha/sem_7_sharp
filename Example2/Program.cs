// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Random rnd = new Random();

double[,] FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void IfExist(int rowNum, int colNum, double[,] matrix)
{
    if (rowNum >= matrix.GetLength(0) || colNum >= matrix.GetLength(1) ||
        rowNum < 0 || colNum < 0)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else Console.WriteLine($"Элемент матрицы в заданой позиции -> {matrix[rowNum, colNum]}");
}

int n = 5, m = 6;
double[,] matrix = new double[n, m];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Введи номер столбца и строки через Enter.");
IfExist(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), matrix);

