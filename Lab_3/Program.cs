//Высокий уровень. 2 Вариант
try
{
    int n = 200;
    int n1 = 200;
    int c = 0;
    int c1 = 0;
    int sum = 0;
    int sum1 = 0;
    while (n <= 300)
    {
        n1 = 200;
        while (n1 <= 300)
        {
            c = 1;
            sum = 0;
            while (c < n)
            {
                if (n % c == 0)
                {
                    sum += c;
                }
                c++;
            }
            c1 = 1;
            sum1 = 0;
            while (c1 < n1)
            {
                if (n1 % c1 == 0)
                {
                    sum1 += c1;
                }
                c1++;
            }
            if ((sum == n1) && (sum1 == n)) Console.WriteLine($"{n} и {n1} - дружественные числа");
            n1++;
        }
        n++;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}