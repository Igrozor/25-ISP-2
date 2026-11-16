using MyLibrary;
Random random = new Random();
double[,] mas = new double[5, 5];

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(10, 20);
        Console.Write($"{mas[i, j], 8:F2} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Среднее арифметическое элементов побочной диагонали: {OurClassLibrary.MultiMatrix(mas)}");
