try
{
    Random rnd = new Random();
    int[] mas = new int[rnd.Next(1, 6)];
    int c = 0;
    for (int i = 1; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(10, 20);
        string binary = Convert.ToString(mas[i], 2);
        Console.Write($"{binary} ");
        c++;
    }
    Console.WriteLine();
    int between = c - 2;
    if (between < 1)
        Console.WriteLine("Чисел, стоящих между макс. и мин. элементами нет.");
    else Console.WriteLine($"Количество чисел, стоящих между макс. и мин. элементами: {between}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}