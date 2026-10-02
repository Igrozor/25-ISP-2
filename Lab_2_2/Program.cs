//Вариант 9 Высокий уровень
try
{
    Console.Write("Введите трёхзначное число: ");
    int m = int.Parse(Console.ReadLine());
    int a = m / 100;
    int b = m / 10 % 10;
    int c = m % 10;
    if ((((a + b + c) / 10) >= 1) && (((a + b + c) / 10) < 10))
        Console.WriteLine("Сумма является двухзначным числом");
    else Console.WriteLine("Сумма не является двухзначным числом");
    if ((((a * b * c) / 100) >= 1) && (((a * b * c) / 100) < 10))
        Console.WriteLine("Произведение является трёхзначным числом");
    else Console.WriteLine("Произведение не является трёхзначным числом");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}