Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"{number} -> да");
else
    Console.WriteLine($"{number} -> нет");