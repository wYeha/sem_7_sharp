// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Random rnd = new Random();

int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 3);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void PrintVector(double[] vector)
{
    Console.WriteLine("Среднее арифметическое столбцов заданного массива:");
    for (int i = 0; i < vector.Length; i++)
    {
        Console.Write($"{vector[i]:F2}; ");
    }
}

double[] Arithmetic(int[,] matrix)
{
    int rows = matrix.GetLength(1);
    double[] res = new double[rows];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res[j] += Convert.ToDouble(matrix[i, j]) / rows;
        }
    }
    return res;
}

int[,] array = new int[5, 6];
PrintMatrix(FillMatrix(array));
double[] result = Arithmetic(array);
PrintVector(result);