//Вариант 8 Высокий уровень
try
{
    int Digits(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        int current = char.IsDigit(s[0]) ? 1 : 0;

        return current + Digits(s.Substring(1));
    }

    string[] strings =
            {
            Console.ReadLine(),
            Console.ReadLine(),
            Console.ReadLine(),
            Console.ReadLine(),
            Console.ReadLine()
        };
    Console.WriteLine("Количество цифр в пяти строках:");
    Console.WriteLine($" {strings[0]} : {Digits(strings[0])}");
    Console.WriteLine($" {strings[1]} : {Digits(strings[1])}");
    Console.WriteLine($" {strings[2]} : {Digits(strings[2])}");
    Console.WriteLine($" {strings[3]} : {Digits(strings[3])}");
    Console.WriteLine($" {strings[4]} : {Digits(strings[4])}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}