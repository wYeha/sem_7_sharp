//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// int m = Convert.ToInt32(Console.ReadLine()), n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[3, 2];
Random rnd = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; i++)
    {
        array[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; i++)
    {
        Console.WriteLine(array[i, j]);
    }
    Console.WriteLine();
}