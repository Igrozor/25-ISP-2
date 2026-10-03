using System.ComponentModel.Design;

try
{
    Console.WriteLine("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    double a=0, b=0, z=0;
    double y=0;
    switch (n)
    {
        case 1:
            {
                a = 1.2; b = 7.2; z = Math.Exp(x);
            }
            break;
        case 2:
            {
                a = -1.5; b = 3.2; z = Math.Exp(2*x);
            }
            break;
        case 3:
            {
                a = 1.7; b = 5.5; z = Math.Exp(3);
            }
            break;
    }
    if (x < a * a * a)
    {
        y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos((z * x + a));
        Console.WriteLine(1);
    }
    else if ((a * a * a <= x) && (x <= b))
    {
        y = Math.Pow(a + b * x, 2) - Math.Sin(a + z * x);
        Console.WriteLine(2);
    }
    else if (x > b)
    {
        y = Math.Sqrt(x - (Math.Sin(b * x + z)));
        Console.WriteLine(3);
    }
    Console.WriteLine($"y = {y:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}