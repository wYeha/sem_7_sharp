// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Random rnd = new Random();

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:F2} ");
        }

        Console.WriteLine();
    }
}

double[,] FillArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.NextDouble() * 100;
        }
    }
    return matrix;
}

Console.WriteLine("Введи m и n через Enter:");
int m = Convert.ToInt32(Console.ReadLine()), n = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(m, n));
