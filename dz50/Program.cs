// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] massiv = new int[3, 10];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(-10, 11);
        Console.Write($"{massiv[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите позицию x :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию y :");
int y = Convert.ToInt32(Console.ReadLine());
if (x < 0 && x > 2 && y < 0 && y > 9)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine($"Значение элемента массива = {massiv[x, y]}");
}




