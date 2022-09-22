// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите колличество строк m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(-10, 11);
        Console.Write($"{massiv[i, j]}  ");
    }
    Console.WriteLine();
}
for (int y = 0; y < n; y++)
{
    double sa=0;
    for (int x = 0; x < m; x++)
    {
        sa = sa + massiv[x, y];  
    }
    Console.WriteLine($"{sa / m}  ");
}
