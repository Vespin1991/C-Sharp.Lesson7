// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Создаем массив m * n ");
Console.WriteLine("Введите колличество строк m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] massiv = new double[m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = Math.Round(new Random().NextDouble() * (-11 + (-10)) - (-10), 1); ;
        Console.Write($"{massiv[i, j]}  ");
    }
    Console.WriteLine();
}
