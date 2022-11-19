// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());   

bool Palindrome(int num)
{
    int result = 0;
    int newNum = num;
    while(num > 0)
    {
        result = result * 10 + num % 10;
        num = num / 10;
    }
    return result == newNum;
}

Console.WriteLine(Palindrome(number) ? $"{number} -> да" : $"{number} -> нет");