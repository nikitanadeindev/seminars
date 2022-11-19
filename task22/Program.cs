Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void RunningSquare(int num)
{
    for(int i = 1; i <= number; ++i)
    {
        Console.Write((Math.Pow(i, 2) + " "));
    }
}

if(number < 1)
    Console.WriteLine("Введите положительное число > 0");
else
    RunningSquare(number);