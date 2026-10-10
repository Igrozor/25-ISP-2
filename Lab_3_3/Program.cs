try
{
    Console.WriteLine("Введите n: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    double sum = 0;
    int m = 1;
    int d = 1;
    do
    {
        sum += (Math.Cos(m * x) / d);
        m++;
        d++;
    }
    while (m <= n);
    Console.WriteLine($"Сумма равна {sum:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}