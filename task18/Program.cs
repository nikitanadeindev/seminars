Console.Write("Введите значение четверти: ");
string quarter  = Console.ReadLine();

string Range(string x)
{
    if(x == "1") return "x > 0 и y > 0";
    if(x == "2") return "x < 0 и y > 0";
    if(x == "3") return "x < 0 и y < 0";
    if(x == "4") return "x > 0 и y < 0";
    return "Введено некорректное значение четверти";
}

string range = Range(quarter);

Console.WriteLine(range);