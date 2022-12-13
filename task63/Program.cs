Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int n)
{
    if(n < 1) return;
    NaturalNumbers(n - 1);
    Console.Write(n + " ");
}

NaturalNumbers(number);