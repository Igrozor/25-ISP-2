int[,] mas = new int[5, 5];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = 0;
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
mas[0, 2] = 1;
mas[1, 2] = 1;
mas[2, 0] = 1;
mas[2, 1] = 1;
mas[2, 2] = 1;
mas[2, 3] = 1;
mas[2, 4] = 1;
mas[3, 2] = 1;
mas[4, 2] = 1;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}