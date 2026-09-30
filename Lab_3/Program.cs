Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int a = number / 100;
int b = number % 100;
int c = b * 10 + a;
Console.WriteLine("Ответ: "+ c);