// Задача 69. Напишите программу которая на вход принимает два числа A и B, и
// возводит число A в целую степень B с помощью рекурсии.

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IncreaseNumber(numA, numB));

int IncreaseNumber(int a, int b)
{
    return b == 0 ? 1 : a * IncreaseNumber(a, b - 1);
}
