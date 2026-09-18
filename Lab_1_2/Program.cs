try
{
    Console.Write("Введите x1, y1: ");
    double x1 = double.Parse(Console.ReadLine());
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите x2, y2: ");
    double x2 = double.Parse(Console.ReadLine());
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("Введите x3, y3: ");
    double x3 = double.Parse(Console.ReadLine());
    double y3 = double.Parse(Console.ReadLine());
    double a = Math.Sqrt(Math.Pow((x1 - x2), 2) + (Math.Pow((y1 - y2), 2)));
    double b = Math.Sqrt(Math.Pow((x2 - x3), 2) + (Math.Pow((y2 - y3), 2)));
    double c = Math.Sqrt(Math.Pow((x3 - x1), 2) + (Math.Pow((y3 - y1), 2)));
    double p = (a + b + c) / 2;
    double C = Math.Sqrt(p * (p - a) * (p - b) * (p - c) );
    Console.WriteLine($"C={C:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}