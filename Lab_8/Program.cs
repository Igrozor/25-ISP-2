using System.Data;

Console.Write("Количество поездов: ");
int n = int.Parse(Console.ReadLine());

Train[] trains = new Train[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Номер поезда: ");
    trains[i].Number = Console.ReadLine();

    Console.Write("Станция отправления: ");
    trains[i].DepartureStation = Console.ReadLine();

    Console.Write("Время отправления: ");
    trains[i].DepartureTime = DateTime.Parse(Console.ReadLine());

    Console.Write("Станция прибытия: ");
    trains[i].ArrivalStation = Console.ReadLine();

    Console.Write("Время прибытия: ");
    trains[i].ArrivalTime = DateTime.Parse(Console.ReadLine());
}

Console.WriteLine("Все поезда:");
for (int i = 0; i < n; i++)
{
    TimeSpan timeInWay = trains[i].ArrivalTime - trains[i].DepartureTime;
    Console.WriteLine($"{trains[i].Number} | {trains[i].DepartureStation} ({trains[i].DepartureTime}) -> {trains[i].ArrivalStation} ({trains[i].ArrivalTime}) | В пути: {(int)timeInWay.TotalHours} ч. {timeInWay.Minutes} мин.");
}

Console.Write("Начало интервала: ");
DateTime start = DateTime.Parse(Console.ReadLine());

Console.Write("Конец интервала: ");
DateTime end = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Поезда из Киева:");
for (int i = 0; i < n; i++)
{
    if (trains[i].DepartureStation == "Киев" &&
        trains[i].DepartureTime >= start &&
        trains[i].DepartureTime <= end)
    {
        Console.WriteLine($"{trains[i].Number} | {trains[i].DepartureStation} ({trains[i].DepartureTime}) -> {trains[i].ArrivalStation} ({trains[i].ArrivalTime})");
    }
}

struct Train
{
    public string Number;
    public string DepartureStation;
    public DateTime DepartureTime;
    public string ArrivalStation;
    public DateTime ArrivalTime;
}