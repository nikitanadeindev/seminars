int number = new Random().Next(10, 99);

int div = number / 10;
int mod = number % 10;
int max;

if(div > mod)
{
    max = div;
    Console.WriteLine($"{number} -> {max}");
}
else
{
    max = mod;
    Console.WriteLine($"{number} -> {max}");
}
