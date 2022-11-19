Console.Write("Введите координаты точки ax: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки ay: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки bx: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки by: ");
double by = Convert.ToDouble(Console.ReadLine());

double Pythagorean(double xa, double ya, double xb, double yb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double result = Math.Round(Math.Sqrt(xc + yc), 2, MidpointRounding.ToZero);
    
    return result;
}

double res = Pythagorean(ax, ay, bx, by);

Console.WriteLine($"A ({ax},{ay}); B ({bx},{by}) -> {res}");