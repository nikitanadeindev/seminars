// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(number1 > number2)
{
    max += number1;
    Console.WriteLine($"Наибольшее число = {max}");
}
else
{
    max += number2;
    Console.WriteLine($"Наибольшее число = {max}");
}