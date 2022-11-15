int number = new Random().Next(100, 999);

int div = number / 100;
int mod = number % 10;

Console.WriteLine($"{number} -> {div * 10 + mod}");