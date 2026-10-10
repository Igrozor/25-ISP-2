try
{
    Console.WriteLine("Введите 2 числа");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    for(int i=a; i<=b; i++)
    {
        Console.Write($"{i} ");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}