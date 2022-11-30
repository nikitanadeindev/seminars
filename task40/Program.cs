Console.Write("Введите значение A: = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B: = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение C: = ");
int c = Convert.ToInt32(Console.ReadLine());

bool TriangleExists(int at, int bt, int ct)
{
    return at < bt + ct && bt < ct + at && ct < bt + at;
}

bool result = TriangleExists(a, b, c);
Console.WriteLine(result ? "Такой треугольник существует" 
                         : "Такого треугольника не существует");