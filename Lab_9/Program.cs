using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первый катет: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второй катет: ");
        double b = Convert.ToDouble(Console.ReadLine());

        RightTriangle triangle = new RightTriangle(a, b);

        Console.WriteLine();
        Console.WriteLine(triangle.GetInfo());
        Console.WriteLine("Площадь треугольника: " + triangle.GetArea());
    }
}

class RightTriangle
{
    private double cathetus1;
    private double cathetus2;

    public RightTriangle(double a, double b)
    {
        cathetus1 = a;
        cathetus2 = b;
    }

    public string GetInfo()
    {
        return $"Прямоугольный треугольник: катет 1 = {cathetus1}, катет 2 = {cathetus2}";
    }

    public double GetArea()
    {
        return 0.5 * cathetus1 * cathetus2;
    }
}
