//DayTime dayTime = DayTime.Morning;
//if (dayTime == DayTime.Morning)
//    Console.WriteLine("Доброе утро!");
//else
//    Console.WriteLine("Привет!");

//DoOperation(10, 5, Operation.Add);          // 15
//DoOperation(10, 5, Operation.Sub);     // 5
//DoOperation(10, 5, Operation.Mult);     // 50
//DoOperation(10, 5, Operation.Div);       // 2
//void DoOperation(double x, double y, Operation op)
//{
//    double result = op switch
//    {
//        Operation.Add => x + y,
//        Operation.Sub => x - y,
//        Operation.Mult => x * y,
//        Operation.Div => x / y
//    };
//    Console.WriteLine(result);
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

//enum Operation
//{
//    Add,
//    Sub,
//    Mult,
//    Div
//}

//Person[] Person = new Person[5];
//for (int i = 0; i < Person.Length; i++)
//{
//    Console.Write("Введите Фамилию:");
//    Person[i].fam = Console.ReadLine()!;
//    Console.Write("Введите Имя:");
//    Person[i].name = Console.ReadLine()!;
//    Console.Write("Введите Отчество:");
//    Person[i].otch = Console.ReadLine()!;
//    Console.Write("Введите Должность:");
//    Person[i].job = Console.ReadLine()!;
//    Console.Write("Введите Пол:");
//    Person[i].sex = Console.ReadLine()!;
//    Console.Write("Введите дату рождения:");
//    Person[i].date = int.Parse(Console.ReadLine()!);
//    Console.WriteLine();
//}
//int max = 0;
//for (int i = 0; i < Person.Length; i++)
//{
//    if (Person[i].date > max) max = Person[i].date;
//}
//struct Person
//{
//    public string fam;
//    public string name;
//    public string otch;
//    public string job;
//    public string sex;
//    public int date;
//    public void Print()
//    {
//        Console.WriteLine($"Фамилия:{fam}, Имя:{name}, Отчество: {otch}, Должность:{job}, Пол:{sex}, ");
//    }

//}

//{((DVD) ? "DVD" : "")}


//Средний уровень 8 вариант

    Person[] people = new Person[5];

    for (int i = 0; i < people.Length; i++)
    {
        Console.Write("Введите Фамилию: ");
        people[i].fam = Console.ReadLine()!;
        Console.Write("Введите Имя: ");
        people[i].name = Console.ReadLine()!;
        Console.Write("Введите Отчество: ");
        people[i].otch = Console.ReadLine()!;
        Console.Write("Введите Должность: ");
        people[i].job = Console.ReadLine()!;
        Console.Write("Введите Пол: ");
        people[i].sex = Console.ReadLine()!;
        Console.Write("Введите год рождения: ");
        people[i].date = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
    }

    int youngestIndex = 0;

    for (int i = 1; i < people.Length; i++)
    {
        if (people[i].date > people[youngestIndex].date)
        {
            youngestIndex = i;
        }
    }

    Console.WriteLine("Самый молодой человек:");
    people[youngestIndex].Print();

struct Person
{
    public string fam;
    public string name;
    public string otch;
    public string job;
    public string sex;
    public int date;

    public void Print()
    {
        Console.WriteLine($"Фамилия: {fam}, Имя: {name}, Отчество: {otch}, Должность: {job}, Пол: {sex}, Год рождения: {date}");
    }
}