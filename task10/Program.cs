Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10 % 10;

Console.WriteLine($"{number} -> {result}");