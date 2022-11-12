// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 2;

while(counter <= number)
{
    Console.Write($"{counter} ");
    counter += 2;
}