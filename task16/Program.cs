Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int squareFirst = firstNumber * firstNumber;
int squareSecond = firstNumber / secondNumber;

if(secondNumber == squareFirst || squareSecond == secondNumber)
    Console.WriteLine($"{firstNumber}, {secondNumber} -> да");
else
    Console.WriteLine($"{firstNumber}, {secondNumber} -> нет");