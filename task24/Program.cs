Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    for(int i = 0; i <= num; i++)
    {
        sum += i;
    }

    return sum;
}

if(number > 0)
{
    int sumDigits = SumDigits(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumDigits}");
}
else
{
    Console.WriteLine("Требуется ввести натуральное число");
}