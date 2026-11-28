//Базовый уровень 8 вариант

RightTriangle triangleConst = new RightTriangle(3, 4);
triangleConst.Print();

Console.WriteLine();

RightTriangle triangleInput = new RightTriangle();
triangleInput.Print();

try
{
    Console.Write("Введите первый катет: ");
    triangleInput.Cathetus1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второй катет: ");
    triangleInput.Cathetus2 = Convert.ToDouble(Console.ReadLine());
    triangleInput.Print();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

class RightTriangle
{
    private double cathetus1;
    public double Cathetus1
    {
        private get
        {
            return cathetus1;
        }
        set
        {
            if (value <= 0) Console.WriteLine("Ошибка!");
            else cathetus1 = value;
        }
    }

    private double cathetus2;
    public double Cathetus2
    {
        private get
        {
            return cathetus2;
        }
        set
        {
            if (value <= 0) Console.WriteLine("Ошибка!");
            else cathetus2 = value;
        }
    }

    public RightTriangle()
    {
        cathetus1 = 10;
        cathetus2 = 10;
    }

    public RightTriangle(double _cathetus1, double _cathetus2)
    {
        this.Cathetus1 = _cathetus1;
        this.Cathetus2 = _cathetus2;
    }

    private double Area()
    {
        return 0.5 * cathetus1 * cathetus2;
    }

    public string GetInfo()
    {
        return $"Первый катет: {Cathetus1}, Второй катет: {Cathetus2}";
    }

    public void Print()
    {
        Console.WriteLine(GetInfo());
        Console.WriteLine("Площадь: " + Area());
    }
}