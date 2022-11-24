Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int IncreaseDigits(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    {
        sum *= i;
    }

    return sum;
}

if(number > 0)
{
    int increaseDigits = IncreaseDigits(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} =  {increaseDigits}");
}
else
{
    Console.WriteLine("Требуется ввести натуральное число");
}