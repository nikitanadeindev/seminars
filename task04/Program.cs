// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (max < number2) max = number2;
if (max < number3) max = number3;

Console.WriteLine($"Наибольшее число = {max}");