// Задача 67. Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе = " + DigitsSum(Math.Abs(number)));

int DigitsSum(int n)
{
    return (n != 0) ? n % 10 + DigitsSum(n / 10) : 0;
}

