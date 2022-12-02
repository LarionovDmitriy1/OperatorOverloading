using OperatorOverloading;
Console.WriteLine();
Console.WriteLine("1. Dollar -> roubles");
Console.WriteLine("2. Перегрузки операторов");
Console.WriteLine();
string menu = Console.ReadLine();
bool parse = int.TryParse(menu, out var select);
if (parse)
{
    if (select == 1)
    {
        Console.WriteLine("Сколько долларов");
        string summ = Console.ReadLine();
        bool parse1 = decimal.TryParse(summ, out var dollars);
        if (parse1)
        {
            Dollar dollar = new() { Summ = dollars };
            Roubles roubles = (Roubles)dollar;
            Console.WriteLine($"В рублях - {roubles.Summ}");
        }
        return;
    }
    else if (select == 2)
    {
        Overloads();
        return;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка");
        Console.WriteLine();
    }
}
void Overloads()
{
    Console.WriteLine($"Введите первое число");
    string number1 = Console.ReadLine();
    bool check1 = int.TryParse(number1, out var result1);
    Console.WriteLine($"Введите второе число");
    string number2 = Console.ReadLine();
    bool check2 = int.TryParse(number2, out var result2);
    var a = new MyNumber { Value = result1 };
    var b = new MyNumber { Value = result2 };
    Console.WriteLine($"Сложение {a.Value + b.Value}");
    Console.WriteLine($"Умножение{a.Value * b.Value}");
    Console.WriteLine($"Вычетание{a.Value - b.Value}");
    Console.WriteLine($"Деление{a.Value / b.Value}");
}