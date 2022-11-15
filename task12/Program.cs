Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int mod = firstNumber % secondNumber;

if(mod == 0)
    Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно");
else
    Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, остаток {mod}");