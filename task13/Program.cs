Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
    Console.WriteLine($"{number} -> третьей цифры нет");
else
{
    int betweenNumber = number;
    while (betweenNumber > 999)
            betweenNumber = betweenNumber / 10;
    Console.WriteLine($"{number} -> {betweenNumber % 10}");
}

