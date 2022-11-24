// Напишите программу которая принимает на вход число и выдает количество цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitsCount(int num)
{
    int count = 0;
    while(num > 0)
    {
        num /= 10;
        count++;
    }

    return count == 0 ? 1 : count;
}

if(number < 0) number *= -1;

int digitsCount = DigitsCount(number);
Console.WriteLine($"{number} -> {digitsCount}");